namespace SmartBoltAdjuster
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.disclaimer_richTextBox = new System.Windows.Forms.RichTextBox();
            this.disclaimer_lbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.help_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // disclaimer_richTextBox
            // 
            this.disclaimer_richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.disclaimer_richTextBox.Location = new System.Drawing.Point(356, 39);
            this.disclaimer_richTextBox.Name = "disclaimer_richTextBox";
            this.disclaimer_richTextBox.Size = new System.Drawing.Size(316, 354);
            this.disclaimer_richTextBox.TabIndex = 0;
            this.disclaimer_richTextBox.Text = resources.GetString("disclaimer_richTextBox.Text");
            // 
            // disclaimer_lbl
            // 
            this.disclaimer_lbl.AutoSize = true;
            this.disclaimer_lbl.Location = new System.Drawing.Point(353, 9);
            this.disclaimer_lbl.Name = "disclaimer_lbl";
            this.disclaimer_lbl.Size = new System.Drawing.Size(162, 13);
            this.disclaimer_lbl.TabIndex = 1;
            this.disclaimer_lbl.Text = "Disclaimer for Smart Bolt Adjuster";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(23, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(316, 354);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // help_lbl
            // 
            this.help_lbl.AutoSize = true;
            this.help_lbl.Location = new System.Drawing.Point(29, 9);
            this.help_lbl.Name = "help_lbl";
            this.help_lbl.Size = new System.Drawing.Size(102, 13);
            this.help_lbl.TabIndex = 3;
            this.help_lbl.Text = "Step-by-Step Guide ";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.help_lbl);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.disclaimer_lbl);
            this.Controls.Add(this.disclaimer_richTextBox);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox disclaimer_richTextBox;
        private System.Windows.Forms.Label disclaimer_lbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label help_lbl;
    }
}