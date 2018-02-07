namespace Robotarm_gui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gp_Send = new System.Windows.Forms.GroupBox();
            this.txt_Send = new System.Windows.Forms.TextBox();
            this.gp_Receive = new System.Windows.Forms.GroupBox();
            this.txt_Recieve = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_PortSwitch = new System.Windows.Forms.Button();
            this.cb_Baudrate = new System.Windows.Forms.ComboBox();
            this.cb_Ports = new System.Windows.Forms.ComboBox();
            this.lab_Ports = new System.Windows.Forms.Label();
            this.lab_Baudrate = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.gp_Send.SuspendLayout();
            this.gp_Receive.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_Send
            // 
            this.gp_Send.Controls.Add(this.txt_Send);
            this.gp_Send.Location = new System.Drawing.Point(12, 191);
            this.gp_Send.Name = "gp_Send";
            this.gp_Send.Size = new System.Drawing.Size(206, 160);
            this.gp_Send.TabIndex = 0;
            this.gp_Send.TabStop = false;
            this.gp_Send.Text = "Send here";
            // 
            // txt_Send
            // 
            this.txt_Send.Enabled = false;
            this.txt_Send.Location = new System.Drawing.Point(3, 16);
            this.txt_Send.Multiline = true;
            this.txt_Send.Name = "txt_Send";
            this.txt_Send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Send.Size = new System.Drawing.Size(197, 138);
            this.txt_Send.TabIndex = 0;
            this.txt_Send.TextChanged += new System.EventHandler(this.txt_Send_TextChanged);
            // 
            // gp_Receive
            // 
            this.gp_Receive.Controls.Add(this.txt_Recieve);
            this.gp_Receive.Location = new System.Drawing.Point(224, 191);
            this.gp_Receive.Name = "gp_Receive";
            this.gp_Receive.Size = new System.Drawing.Size(206, 160);
            this.gp_Receive.TabIndex = 1;
            this.gp_Receive.TabStop = false;
            this.gp_Receive.Text = "Recived here";
            // 
            // txt_Recieve
            // 
            this.txt_Recieve.Location = new System.Drawing.Point(3, 16);
            this.txt_Recieve.Multiline = true;
            this.txt_Recieve.Name = "txt_Recieve";
            this.txt_Recieve.ReadOnly = true;
            this.txt_Recieve.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Recieve.Size = new System.Drawing.Size(197, 138);
            this.txt_Recieve.TabIndex = 0;
            this.txt_Recieve.TextChanged += new System.EventHandler(this.txt_Recieve_TextChanged);
            // 
            // btn_Send
            // 
            this.btn_Send.Enabled = false;
            this.btn_Send.Location = new System.Drawing.Point(15, 357);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 2;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_PortSwitch
            // 
            this.btn_PortSwitch.Location = new System.Drawing.Point(286, 149);
            this.btn_PortSwitch.Name = "btn_PortSwitch";
            this.btn_PortSwitch.Size = new System.Drawing.Size(75, 36);
            this.btn_PortSwitch.TabIndex = 3;
            this.btn_PortSwitch.Text = "Open/Close Port";
            this.btn_PortSwitch.UseVisualStyleBackColor = true;
            this.btn_PortSwitch.Click += new System.EventHandler(this.btn_PortSwitch_Click);
            // 
            // cb_Baudrate
            // 
            this.cb_Baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Baudrate.FormattingEnabled = true;
            this.cb_Baudrate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.cb_Baudrate.Location = new System.Drawing.Point(142, 34);
            this.cb_Baudrate.Name = "cb_Baudrate";
            this.cb_Baudrate.Size = new System.Drawing.Size(121, 21);
            this.cb_Baudrate.TabIndex = 4;
            this.cb_Baudrate.SelectedIndexChanged += new System.EventHandler(this.cb_Baudrate_SelectedIndexChanged);
            // 
            // cb_Ports
            // 
            this.cb_Ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Ports.FormattingEnabled = true;
            this.cb_Ports.Location = new System.Drawing.Point(15, 34);
            this.cb_Ports.Name = "cb_Ports";
            this.cb_Ports.Size = new System.Drawing.Size(121, 21);
            this.cb_Ports.TabIndex = 1;
            this.cb_Ports.SelectedIndexChanged += new System.EventHandler(this.cb_Ports_SelectedIndexChanged);
            // 
            // lab_Ports
            // 
            this.lab_Ports.AutoSize = true;
            this.lab_Ports.Location = new System.Drawing.Point(15, 13);
            this.lab_Ports.Name = "lab_Ports";
            this.lab_Ports.Size = new System.Drawing.Size(31, 13);
            this.lab_Ports.TabIndex = 5;
            this.lab_Ports.Text = "Ports";
            // 
            // lab_Baudrate
            // 
            this.lab_Baudrate.AutoSize = true;
            this.lab_Baudrate.Location = new System.Drawing.Point(139, 13);
            this.lab_Baudrate.Name = "lab_Baudrate";
            this.lab_Baudrate.Size = new System.Drawing.Size(50, 13);
            this.lab_Baudrate.TabIndex = 6;
            this.lab_Baudrate.Text = "Baudrate";
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Red;
            this.btn_Stop.Location = new System.Drawing.Point(12, 135);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(78, 37);
            this.btn_Stop.TabIndex = 7;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Green;
            this.btn_Start.Location = new System.Drawing.Point(96, 135);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(78, 37);
            this.btn_Start.TabIndex = 8;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // txt_Status
            // 
            this.txt_Status.BackColor = System.Drawing.Color.Gray;
            this.txt_Status.Location = new System.Drawing.Point(180, 144);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.ReadOnly = true;
            this.txt_Status.Size = new System.Drawing.Size(100, 20);
            this.txt_Status.TabIndex = 9;
            this.txt_Status.Text = "N/A";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Enabled = false;
            this.btn_Clear.Location = new System.Drawing.Point(224, 357);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear Log";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 402);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.lab_Baudrate);
            this.Controls.Add(this.lab_Ports);
            this.Controls.Add(this.cb_Baudrate);
            this.Controls.Add(this.cb_Ports);
            this.Controls.Add(this.btn_PortSwitch);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.gp_Receive);
            this.Controls.Add(this.gp_Send);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Robot Arm Control Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gp_Send.ResumeLayout(false);
            this.gp_Send.PerformLayout();
            this.gp_Receive.ResumeLayout(false);
            this.gp_Receive.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_Send;
        private System.Windows.Forms.TextBox txt_Send;
        private System.Windows.Forms.GroupBox gp_Receive;
        private System.Windows.Forms.TextBox txt_Recieve;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_PortSwitch;
        private System.Windows.Forms.ComboBox cb_Baudrate;
        private System.Windows.Forms.ComboBox cb_Ports;
        private System.Windows.Forms.Label lab_Ports;
        private System.Windows.Forms.Label lab_Baudrate;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Start;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Button btn_Clear;
    }
}

