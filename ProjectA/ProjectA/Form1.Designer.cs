namespace ProjectA
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.txtlast = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.cmdregister = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtregno = new System.Windows.Forms.TextBox();
            this.PersonInfo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PersonInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DOB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(242, 47);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(200, 20);
            this.txtfirst.TabIndex = 6;
            // 
            // txtlast
            // 
            this.txtlast.Location = new System.Drawing.Point(242, 87);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(200, 20);
            this.txtlast.TabIndex = 7;
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(242, 125);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(200, 20);
            this.txtcontact.TabIndex = 8;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(242, 163);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(200, 20);
            this.txtemail.TabIndex = 9;
            // 
            // cmdregister
            // 
            this.cmdregister.Location = new System.Drawing.Point(367, 321);
            this.cmdregister.Name = "cmdregister";
            this.cmdregister.Size = new System.Drawing.Size(75, 23);
            this.cmdregister.TabIndex = 13;
            this.cmdregister.Text = "Register";
            this.cmdregister.UseVisualStyleBackColor = true;
            this.cmdregister.Click += new System.EventHandler(this.cmdregister_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(242, 240);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // dtDOB
            // 
            this.dtDOB.Location = new System.Drawing.Point(242, 199);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(200, 20);
            this.dtDOB.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "RegNo#";
            // 
            // txtregno
            // 
            this.txtregno.Location = new System.Drawing.Point(242, 278);
            this.txtregno.Name = "txtregno";
            this.txtregno.Size = new System.Drawing.Size(200, 20);
            this.txtregno.TabIndex = 18;
            // 
            // PersonInfo
            // 
            this.PersonInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonInfo.Location = new System.Drawing.Point(498, 47);
            this.PersonInfo.Name = "PersonInfo";
            this.PersonInfo.Size = new System.Drawing.Size(433, 251);
            this.PersonInfo.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Back To Main";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PersonInfo);
            this.Controls.Add(this.txtregno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmdregister);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtlast);
            this.Controls.Add(this.txtfirst);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.PersonInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.TextBox txtlast;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button cmdregister;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtregno;
        private System.Windows.Forms.DataGridView PersonInfo;
        private System.Windows.Forms.Button button1;
    }
}

