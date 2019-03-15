namespace ProjectA
{
    partial class Evaluation
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtweightage = new System.Windows.Forms.TextBox();
            this.evaluationdata = new System.Windows.Forms.DataGridView();
            this.cmdenter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Marks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Weightage";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(187, 32);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(160, 20);
            this.txtname.TabIndex = 3;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(187, 76);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(160, 20);
            this.txttotal.TabIndex = 4;
            // 
            // txtweightage
            // 
            this.txtweightage.Location = new System.Drawing.Point(187, 122);
            this.txtweightage.Name = "txtweightage";
            this.txtweightage.Size = new System.Drawing.Size(160, 20);
            this.txtweightage.TabIndex = 5;
            // 
            // evaluationdata
            // 
            this.evaluationdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.evaluationdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Update});
            this.evaluationdata.Location = new System.Drawing.Point(69, 160);
            this.evaluationdata.Name = "evaluationdata";
            this.evaluationdata.Size = new System.Drawing.Size(315, 156);
            this.evaluationdata.TabIndex = 6;
            this.evaluationdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.evaluationdata_CellContentClick);
            // 
            // cmdenter
            // 
            this.cmdenter.Location = new System.Drawing.Point(294, 369);
            this.cmdenter.Name = "cmdenter";
            this.cmdenter.Size = new System.Drawing.Size(120, 23);
            this.cmdenter.TabIndex = 7;
            this.cmdenter.Text = "Enter";
            this.cmdenter.UseVisualStyleBackColor = true;
            this.cmdenter.Click += new System.EventHandler(this.cmdenter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back to Main";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdenter);
            this.Controls.Add(this.evaluationdata);
            this.Controls.Add(this.txtweightage);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Evaluation";
            this.Text = "Evaluation";
            ((System.ComponentModel.ISupportInitialize)(this.evaluationdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtweightage;
        private System.Windows.Forms.DataGridView evaluationdata;
        private System.Windows.Forms.Button cmdenter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
    }
}