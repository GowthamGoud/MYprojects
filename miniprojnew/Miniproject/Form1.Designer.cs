namespace Miniproject
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textLocalport = new System.Windows.Forms.TextBox();
            this.textLocalip = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textFreindport = new System.Windows.Forms.TextBox();
            this.textFriendIp = new System.Windows.Forms.TextBox();
            this.listmessage = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textmsg = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textLocalport);
            this.groupBox1.Controls.Add(this.textLocalip);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "sender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ip";
            // 
            // textLocalport
            // 
            this.textLocalport.Location = new System.Drawing.Point(113, 86);
            this.textLocalport.Name = "textLocalport";
            this.textLocalport.Size = new System.Drawing.Size(100, 20);
            this.textLocalport.TabIndex = 1;
            // 
            // textLocalip
            // 
            this.textLocalip.Location = new System.Drawing.Point(113, 33);
            this.textLocalip.Name = "textLocalip";
            this.textLocalip.Size = new System.Drawing.Size(100, 20);
            this.textLocalip.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textFreindport);
            this.groupBox2.Controls.Add(this.textFriendIp);
            this.groupBox2.Location = new System.Drawing.Point(301, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "receiver";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ip";
            // 
            // textFreindport
            // 
            this.textFreindport.Location = new System.Drawing.Point(99, 74);
            this.textFreindport.Name = "textFreindport";
            this.textFreindport.Size = new System.Drawing.Size(100, 20);
            this.textFreindport.TabIndex = 2;
            // 
            // textFriendIp
            // 
            this.textFriendIp.Location = new System.Drawing.Point(99, 19);
            this.textFriendIp.Name = "textFriendIp";
            this.textFriendIp.Size = new System.Drawing.Size(100, 20);
            this.textFriendIp.TabIndex = 1;
            // 
            // listmessage
            // 
            this.listmessage.FormattingEnabled = true;
            this.listmessage.Location = new System.Drawing.Point(24, 149);
            this.listmessage.Name = "listmessage";
            this.listmessage.Size = new System.Drawing.Size(604, 147);
            this.listmessage.TabIndex = 2;
            this.listmessage.SelectedIndexChanged += new System.EventHandler(this.listmessage_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textmsg
            // 
            this.textmsg.Location = new System.Drawing.Point(24, 336);
            this.textmsg.Name = "textmsg";
            this.textmsg.Size = new System.Drawing.Size(382, 20);
            this.textmsg.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 52);
            this.button2.TabIndex = 5;
            this.button2.Text = "send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(662, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(266, 277);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(500, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 54);
            this.button3.TabIndex = 8;
            this.button3.Text = "Send files";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 397);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textmsg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listmessage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLocalport;
        private System.Windows.Forms.TextBox textLocalip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFreindport;
        private System.Windows.Forms.TextBox textFriendIp;
        private System.Windows.Forms.ListBox listmessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textmsg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
    }
}

