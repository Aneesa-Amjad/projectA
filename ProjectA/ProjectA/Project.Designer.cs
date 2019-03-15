namespace ProjectA
{
    partial class Project
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
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.projectdata = new System.Windows.Forms.DataGridView();
            this.cmdprojectenter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.projectdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(186, 31);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(159, 20);
            this.txttitle.TabIndex = 2;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(186, 81);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(159, 20);
            this.txtdescription.TabIndex = 3;
            // 
            // projectdata
            // 
            this.projectdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Update});
            this.projectdata.Location = new System.Drawing.Point(42, 123);
            this.projectdata.Name = "projectdata";
            this.projectdata.Size = new System.Drawing.Size(360, 203);
            this.projectdata.TabIndex = 4;
            this.projectdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectdata_CellContentClick);
            // 
            // cmdprojectenter
            // 
            this.cmdprojectenter.Location = new System.Drawing.Point(295, 376);
            this.cmdprojectenter.Name = "cmdprojectenter";
            this.cmdprojectenter.Size = new System.Drawing.Size(107, 23);
            this.cmdprojectenter.TabIndex = 5;
            this.cmdprojectenter.Text = "Enter";
            this.cmdprojectenter.UseVisualStyleBackColor = true;
            this.cmdprojectenter.Click += new System.EventHandler(this.cmdprojectenter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back To Main";
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
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdprojectenter);
            this.Controls.Add(this.projectdata);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Project";
            this.Text = "Project";
            ((System.ComponentModel.ISupportInitialize)(this.projectdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.DataGridView projectdata;
        private System.Windows.Forms.Button cmdprojectenter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
    }
}