namespace Balancing_robot_GUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showData = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.ComboBox();
            this.baudrate = new System.Windows.Forms.ComboBox();
            this.dcon_button = new System.Windows.Forms.Button();
            this.con_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.z1 = new ZedGraph.ZedGraphControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.send1 = new System.Windows.Forms.Button();
            this.send2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.status.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.send2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.send1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.showData);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Controls.Add(this.baudrate);
            this.groupBox1.Controls.Add(this.dcon_button);
            this.groupBox1.Controls.Add(this.con_button);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuratiion";
            // 
            // showData
            // 
            this.showData.ContextMenuStrip = this.contextMenuStrip1;
            this.showData.Location = new System.Drawing.Point(25, 61);
            this.showData.Multiline = true;
            this.showData.Name = "showData";
            this.showData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showData.Size = new System.Drawing.Size(228, 49);
            this.showData.TabIndex = 8;
            // 
            // port
            // 
            this.port.FormattingEnabled = true;
            this.port.Location = new System.Drawing.Point(59, 23);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(102, 21);
            this.port.TabIndex = 7;
            // 
            // baudrate
            // 
            this.baudrate.FormattingEnabled = true;
            this.baudrate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.baudrate.Location = new System.Drawing.Point(243, 23);
            this.baudrate.Name = "baudrate";
            this.baudrate.Size = new System.Drawing.Size(102, 21);
            this.baudrate.TabIndex = 6;
            // 
            // dcon_button
            // 
            this.dcon_button.Enabled = false;
            this.dcon_button.Location = new System.Drawing.Point(465, 21);
            this.dcon_button.Name = "dcon_button";
            this.dcon_button.Size = new System.Drawing.Size(75, 23);
            this.dcon_button.TabIndex = 5;
            this.dcon_button.Text = "Disconnect";
            this.dcon_button.UseVisualStyleBackColor = true;
            this.dcon_button.Click += new System.EventHandler(this.dcon_button_Click);
            // 
            // con_button
            // 
            this.con_button.Location = new System.Drawing.Point(370, 21);
            this.con_button.Name = "con_button";
            this.con_button.Size = new System.Drawing.Size(75, 23);
            this.con_button.TabIndex = 4;
            this.con_button.Text = "Connect";
            this.con_button.UseVisualStyleBackColor = true;
            this.con_button.Click += new System.EventHandler(this.con_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudrate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ports";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // z1
            // 
            this.z1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z1.Location = new System.Drawing.Point(16, 156);
            this.z1.Margin = new System.Windows.Forms.Padding(4);
            this.z1.Name = "z1";
            this.z1.ScrollGrace = 0D;
            this.z1.ScrollMaxX = 0D;
            this.z1.ScrollMaxY = 0D;
            this.z1.ScrollMaxY2 = 0D;
            this.z1.ScrollMinX = 0D;
            this.z1.ScrollMinY = 0D;
            this.z1.ScrollMinY2 = 0D;
            this.z1.Size = new System.Drawing.Size(553, 281);
            this.z1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(289, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 10;
            // 
            // send1
            // 
            this.send1.Enabled = false;
            this.send1.Location = new System.Drawing.Point(465, 59);
            this.send1.Name = "send1";
            this.send1.Size = new System.Drawing.Size(75, 23);
            this.send1.TabIndex = 12;
            this.send1.Text = "Send";
            this.send1.UseVisualStyleBackColor = true;
            this.send1.Click += new System.EventHandler(this.send1_Click);
            // 
            // send2
            // 
            this.send2.Enabled = false;
            this.send2.Location = new System.Drawing.Point(465, 88);
            this.send2.Name = "send2";
            this.send2.Size = new System.Drawing.Size(75, 23);
            this.send2.TabIndex = 14;
            this.send2.Text = "Send";
            this.send2.UseVisualStyleBackColor = true;
            this.send2.Click += new System.EventHandler(this.send2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(289, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 20);
            this.textBox2.TabIndex = 13;
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.status.Location = new System.Drawing.Point(0, 444);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(582, 22);
            this.status.TabIndex = 2;
            this.status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(127, 17);
            this.toolStripStatusLabel1.Text = "Created by Phuc Thinh";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyItem,
            this.clearAllItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // CopyItem
            // 
            this.CopyItem.Name = "CopyItem";
            this.CopyItem.Size = new System.Drawing.Size(180, 22);
            this.CopyItem.Text = "Copy";
            this.CopyItem.Click += new System.EventHandler(this.CopyItem_Click);
            // 
            // clearAllItem
            // 
            this.clearAllItem.Name = "clearAllItem";
            this.clearAllItem.Size = new System.Drawing.Size(180, 22);
            this.clearAllItem.Text = "Clear all";
            this.clearAllItem.Click += new System.EventHandler(this.clearAllItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 466);
            this.Controls.Add(this.status);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dcon_button;
        private System.Windows.Forms.Button con_button;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox baudrate;
        private System.Windows.Forms.ComboBox port;
        private ZedGraph.ZedGraphControl z1;
        private System.Windows.Forms.TextBox showData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button send2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button send1;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CopyItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllItem;
    }
}

