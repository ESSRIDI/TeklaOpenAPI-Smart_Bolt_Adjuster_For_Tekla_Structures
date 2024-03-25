namespace SmartBoltAdjuster
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.open_excel_file_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pickerBolts_rbtn = new System.Windows.Forms.RadioButton();
            this.allBoltsSelected_rbtn = new System.Windows.Forms.RadioButton();
            this.selectionGroup = new System.Windows.Forms.GroupBox();
            this.apply_btn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userGuide_lbl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.selectionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // open_excel_file_btn
            // 
            this.open_excel_file_btn.Location = new System.Drawing.Point(21, 24);
            this.open_excel_file_btn.Name = "open_excel_file_btn";
            this.open_excel_file_btn.Size = new System.Drawing.Size(104, 47);
            this.open_excel_file_btn.TabIndex = 1;
            this.open_excel_file_btn.Text = "Open an Excel file";
            this.open_excel_file_btn.UseVisualStyleBackColor = true;
            this.open_excel_file_btn.Click += new System.EventHandler(this.open_excel_file_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(21, 88);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(299, 185);
            this.dataGridView.TabIndex = 2;
            // 
            // pickerBolts_rbtn
            // 
            this.pickerBolts_rbtn.AutoSize = true;
            this.pickerBolts_rbtn.Location = new System.Drawing.Point(27, 19);
            this.pickerBolts_rbtn.Name = "pickerBolts_rbtn";
            this.pickerBolts_rbtn.Size = new System.Drawing.Size(80, 17);
            this.pickerBolts_rbtn.TabIndex = 4;
            this.pickerBolts_rbtn.TabStop = true;
            this.pickerBolts_rbtn.Text = "Select bolts";
            this.pickerBolts_rbtn.UseVisualStyleBackColor = true;
           // this.pickerBolts_rbtn.CheckedChanged += new System.EventHandler(this.pickerBolts_rbtn_CheckedChanged);
            // 
            // allBoltsSelected_rbtn
            // 
            this.allBoltsSelected_rbtn.AutoSize = true;
            this.allBoltsSelected_rbtn.Location = new System.Drawing.Point(27, 42);
            this.allBoltsSelected_rbtn.Name = "allBoltsSelected_rbtn";
            this.allBoltsSelected_rbtn.Size = new System.Drawing.Size(61, 17);
            this.allBoltsSelected_rbtn.TabIndex = 5;
            this.allBoltsSelected_rbtn.TabStop = true;
            this.allBoltsSelected_rbtn.Text = "All bolts";
            this.allBoltsSelected_rbtn.UseVisualStyleBackColor = true;
            this.allBoltsSelected_rbtn.CheckedChanged += new System.EventHandler(this.allBoltsSelected_rbtn_CheckedChanged);
            // 
            // selectionGroup
            // 
            this.selectionGroup.Controls.Add(this.apply_btn);
            this.selectionGroup.Controls.Add(this.pickerBolts_rbtn);
            this.selectionGroup.Controls.Add(this.allBoltsSelected_rbtn);
            this.selectionGroup.Location = new System.Drawing.Point(352, 156);
            this.selectionGroup.Name = "selectionGroup";
            this.selectionGroup.Size = new System.Drawing.Size(200, 100);
            this.selectionGroup.TabIndex = 6;
            this.selectionGroup.TabStop = false;
            this.selectionGroup.Text = "Selection";
            // 
            // apply_btn
            // 
            this.apply_btn.Location = new System.Drawing.Point(99, 66);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(89, 23);
            this.apply_btn.TabIndex = 6;
            this.apply_btn.Text = "Apply";
            this.apply_btn.UseVisualStyleBackColor = true;
            this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(353, 263);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(199, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Copyright © 2024 KE. All rights reserved.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartBoltAdjuster.Properties.Resources.bolt_e;
            this.pictureBox1.Location = new System.Drawing.Point(396, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 130);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // userGuide_lbl
            // 
            this.userGuide_lbl.AutoSize = true;
            this.userGuide_lbl.LinkColor = System.Drawing.Color.Olive;
            this.userGuide_lbl.Location = new System.Drawing.Point(18, 8);
            this.userGuide_lbl.Name = "userGuide_lbl";
            this.userGuide_lbl.Size = new System.Drawing.Size(58, 13);
            this.userGuide_lbl.TabIndex = 9;
            this.userGuide_lbl.TabStop = true;
            this.userGuide_lbl.Text = "User guide";
            this.userGuide_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.userGuide_lbl_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(588, 285);
            this.Controls.Add(this.userGuide_lbl);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.selectionGroup);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.open_excel_file_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Smart Bolt Adjuster";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.selectionGroup.ResumeLayout(false);
            this.selectionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button open_excel_file_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.RadioButton pickerBolts_rbtn;
        private System.Windows.Forms.RadioButton allBoltsSelected_rbtn;
        private System.Windows.Forms.GroupBox selectionGroup;
        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel userGuide_lbl;
    }
}

