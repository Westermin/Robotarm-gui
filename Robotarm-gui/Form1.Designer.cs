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
            this.gp_Send = new System.Windows.Forms.GroupBox();
            this.txt_Send = new System.Windows.Forms.TextBox();
            this.gp_Receive = new System.Windows.Forms.GroupBox();
            this.txt_Recieve = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_Baudrate = new System.Windows.Forms.ComboBox();
            this.cb_Ports = new System.Windows.Forms.ComboBox();
            this.lab_Ports = new System.Windows.Forms.Label();
            this.lab_Baudrate = new System.Windows.Forms.Label();
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
            this.txt_Send.Location = new System.Drawing.Point(3, 16);
            this.txt_Send.Multiline = true;
            this.txt_Send.Name = "txt_Send";
            this.txt_Send.Size = new System.Drawing.Size(197, 138);
            this.txt_Send.TabIndex = 0;
            // 
            // gp_Receive
            // 
            this.gp_Receive.Controls.Add(this.txt_Recieve);
            this.gp_Receive.Location = new System.Drawing.Point(224, 191);
            this.gp_Receive.Name = "gp_Receive";
            this.gp_Receive.Size = new System.Drawing.Size(206, 160);
            this.gp_Receive.TabIndex = 1;
            this.gp_Receive.TabStop = false;
            this.gp_Receive.Text = "Send here";
            // 
            // txt_Recieve
            // 
            this.txt_Recieve.Location = new System.Drawing.Point(3, 16);
            this.txt_Recieve.Multiline = true;
            this.txt_Recieve.Name = "txt_Recieve";
            this.txt_Recieve.Size = new System.Drawing.Size(197, 138);
            this.txt_Recieve.TabIndex = 0;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(15, 357);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 2;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Open/Close Port";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cb_Baudrate
            // 
            this.cb_Baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Baudrate.FormattingEnabled = true;
            this.cb_Baudrate.Location = new System.Drawing.Point(169, 34);
            this.cb_Baudrate.Name = "cb_Baudrate";
            this.cb_Baudrate.Size = new System.Drawing.Size(121, 21);
            this.cb_Baudrate.TabIndex = 4;
            // 
            // cb_Ports
            // 
            this.cb_Ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Ports.FormattingEnabled = true;
            this.cb_Ports.Location = new System.Drawing.Point(15, 34);
            this.cb_Ports.Name = "cb_Ports";
            this.cb_Ports.Size = new System.Drawing.Size(121, 21);
            this.cb_Ports.TabIndex = 1;
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
            this.lab_Baudrate.Location = new System.Drawing.Point(166, 13);
            this.lab_Baudrate.Name = "lab_Baudrate";
            this.lab_Baudrate.Size = new System.Drawing.Size(50, 13);
            this.lab_Baudrate.TabIndex = 6;
            this.lab_Baudrate.Text = "Baudrate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 454);
            this.Controls.Add(this.lab_Baudrate);
            this.Controls.Add(this.lab_Ports);
            this.Controls.Add(this.cb_Baudrate);
            this.Controls.Add(this.cb_Ports);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.gp_Receive);
            this.Controls.Add(this.gp_Send);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_Baudrate;
        private System.Windows.Forms.ComboBox cb_Ports;
        private System.Windows.Forms.Label lab_Ports;
        private System.Windows.Forms.Label lab_Baudrate;
    }
}

