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
        public Form1()
        {
            InitializeComponent();
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
    }
}
