namespace Qbit_SanalMakine
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
            components = new System.ComponentModel.Container();
            timer = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            check1 = new CheckBox();
            txtPort = new TextBox();
            txtIP = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Interval = 500;
            timer.Tick += timer_Tick;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Font = new Font("Consolas", 10F, FontStyle.Bold);
            textBox1.ForeColor = Color.Blue;
            textBox1.Location = new Point(0, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(790, 23);
            textBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(check1);
            groupBox1.Controls.Add(txtPort);
            groupBox1.Controls.Add(txtIP);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(790, 56);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox2.Location = new Point(263, 19);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(75, 29);
            textBox2.TabIndex = 9;
            textBox2.Text = "500";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.Location = new Point(344, 19);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 8;
            button3.Text = "Otomatik";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(712, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 38);
            button2.TabIndex = 7;
            button2.Text = "Kapat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // check1
            // 
            check1.AutoSize = true;
            check1.Location = new Point(196, 28);
            check1.Name = "check1";
            check1.Size = new Size(15, 14);
            check1.TabIndex = 6;
            check1.UseVisualStyleBackColor = true;
            check1.CheckedChanged += check1_CheckedChanged;
            // 
            // txtPort
            // 
            txtPort.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtPort.Location = new Point(138, 19);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(52, 29);
            txtPort.TabIndex = 5;
            txtPort.Text = "8000";
            // 
            // txtIP
            // 
            txtIP.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtIP.Location = new Point(6, 19);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(117, 29);
            txtIP.TabIndex = 2;
            txtIP.Text = "192.168.0.253";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 128);
            label1.Name = "label1";
            label1.Size = new Size(790, 21);
            label1.TabIndex = 8;
            label1.Text = "Hata Mesajı";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(button1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(790, 49);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Test Data";
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox3.Location = new Point(3, 19);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(709, 29);
            textBox3.TabIndex = 3;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(712, 19);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 2;
            button1.Text = "Test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 172);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Qbit_SanalKazan";
            TopMost = true;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox txtPort;
        private TextBox txtIP;
        private CheckBox check1;
        private Button button2;
        private Label label1;
        private Button button3;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private Button button1;
    }
}