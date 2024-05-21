/*
 * Copyright 2024 Thanh Vinh Nguyen (itsmevjnk)
 * This file is part of HVSequencerController.
 * 
 * HVSequencerController is free software: you can redistribute it 
 * and/or modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation, either version 3 of
 * the License, or (at your option) any later version.

 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.

 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System.IO.Ports;
using System.Text;

namespace HVSequencerController
{
    internal class Device
    {
        /* serial port object */
        private SerialPort _serial = new SerialPort();
        public bool Connected { get { return _serial.IsOpen; } }

        /* device state */
        public const decimal VOLTAGE_MIN = 2.000m;
        public const decimal VOLTAGE_MAX = 7.000m;
        private decimal[] _voltages = [0m, 0m, 0m, 0m]; // 0 = turned off

        private void SetChannelVoltageStub(int channel, decimal value)
        {
            if(channel < 0 || channel >= _voltages.Length) throw new ArgumentOutOfRangeException(nameof(channel));

            if (value < VOLTAGE_MIN) value = 0; // off
            else if (value > VOLTAGE_MAX) value = VOLTAGE_MAX; // clamp to max

            _serial.Write($"{value:0.000}{ new char[]{'a', 'b', 'c', 'd'}[channel] }");
            _voltages[channel] = value;
        }

        public decimal Ch1Volt
        {
            get { return _voltages[0]; }
            set { SetChannelVoltageStub(0, value); }
        }
        public decimal Ch2Volt
        {
            get { return _voltages[1]; }
            set { SetChannelVoltageStub(1, value); }
        }
        public decimal Ch3Volt
        {
            get { return _voltages[2]; }
            set { SetChannelVoltageStub(2, value); }
        }
        public decimal Ch4Volt
        {
            get { return _voltages[3]; }
            set { SetChannelVoltageStub(3, value); }
        }

        /* data reception handling */
        public delegate void DataReceivedHandler(string data); // delegate for handling data received events
        public List<DataReceivedHandler> OnDataReceived = new List<DataReceivedHandler>(); // list of handlers

        private void _serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            /* get data */
            var dataBytes = new char[100];
            var dataSb = new StringBuilder();
            int bytesRead;
            do
            {
                bytesRead = _serial.Read(dataBytes, 0, dataBytes.Length);
                dataSb.Append(dataBytes); // append what we just read
            }
            while (bytesRead == dataBytes.Length);
            var data = dataSb.ToString(); // generate output string
            foreach (var handler in OnDataReceived) handler(data); // call our callbacks
        }

        /* class constructor */
        public Device()
        {
            /* configure common serial port settings */
            _serial.Parity = Parity.None; _serial.DataBits = 8; _serial.StopBits = StopBits.One; _serial.Handshake = Handshake.None;
            _serial.ReadTimeout = 500; _serial.WriteTimeout = 100;
            _serial.DataReceived += _serial_DataReceived;
        }

        /* get list of available serial ports */
        public static string[] GetPorts()
        {
            return SerialPort.GetPortNames();
        }

        /* connect to device */
        public void Connect(string port, int baud)
        {
            if (Connected) _serial.Close(); // close previous port

            _serial.PortName = port; _serial.BaudRate = baud;
            _serial.Open();
        }

        /* disconnect from device */
        public void Disconnect()
        {
            if (Connected) _serial.Close();
        }

        /* reset device to initial state (all channels off) */
        public void Reset()
        {
            if (!Connected) throw new InvalidOperationException("Device is not connected");
            Array.Clear(_voltages, 0, _voltages.Length); // set all values to 0 (off)
            _serial.Write("r"); // send reset command
        }
    }
}
