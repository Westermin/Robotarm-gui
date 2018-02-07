using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Robotarm_gui
{
    public partial class Form1 : Form
    {
        bool toggle = true;
        public Form1()
        {
            InitializeComponent();
            getPorts();
        }
        void getPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            cb_Ports.Items.AddRange(ports);
        }

        private void cb_Ports_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            txt_Status.Text = "Started!";
            txt_Status.BackColor = Color.Green;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            txt_Status.Text = "Stopped";
            txt_Status.BackColor = Color.Red;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            txt_Send.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cb_Baudrate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Recieve.Clear();
        }

        private void txt_Recieve_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_PortSwitch_Click(object sender, EventArgs e)
        {
            if (toggle == true)
            {
                    if (cb_Ports.Text == "" || cb_Baudrate.Text == "")
                    {
                        txt_Recieve.Text = "Please select a valid Port and Baudrate.";
                    }
                    else
                    {
                        serialPort1.PortName = cb_Ports.Text;
                        serialPort1.BaudRate = Convert.ToInt32(cb_Baudrate.Text);
                        serialPort1.Open();
                        txt_Recieve.Text = "Port opened!";
                        btn_PortSwitch.BackColor = Color.Green;
                        toggle = !toggle;
                    }
                
            }
            else
                {
                serialPort1.Close();
                serialPort1.PortName = "0";
                serialPort1.BaudRate = 1;
                txt_Recieve.Text = "Port closed!";
                btn_PortSwitch.BackColor = Color.Red;
                toggle = !toggle;
                }
        }
    }
}
