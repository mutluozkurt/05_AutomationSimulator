namespace _05_AutomationSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.IniLinksBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IniRechtsBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IniMitteBox = new System.Windows.Forms.PictureBox();
            this.WagonPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WagonText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PositionEnabledCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.IniLinksBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IniRechtsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IniMitteBox)).BeginInit();
            this.WagonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // IniLinksBox
            // 
            this.IniLinksBox.BackColor = System.Drawing.Color.Black;
            this.IniLinksBox.Location = new System.Drawing.Point(50, 200);
            this.IniLinksBox.Name = "IniLinksBox";
            this.IniLinksBox.Size = new System.Drawing.Size(30, 50);
            this.IniLinksBox.TabIndex = 0;
            this.IniLinksBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Left sensor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(881, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Right sensor";
            // 
            // IniRechtsBox
            // 
            this.IniRechtsBox.BackColor = System.Drawing.Color.Black;
            this.IniRechtsBox.Location = new System.Drawing.Point(907, 200);
            this.IniRechtsBox.Name = "IniRechtsBox";
            this.IniRechtsBox.Size = new System.Drawing.Size(30, 50);
            this.IniRechtsBox.TabIndex = 2;
            this.IniRechtsBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Middle sensor";
            // 
            // IniMitteBox
            // 
            this.IniMitteBox.BackColor = System.Drawing.Color.Black;
            this.IniMitteBox.Location = new System.Drawing.Point(706, 200);
            this.IniMitteBox.Name = "IniMitteBox";
            this.IniMitteBox.Size = new System.Drawing.Size(30, 50);
            this.IniMitteBox.TabIndex = 4;
            this.IniMitteBox.TabStop = false;
            // 
            // WagonPanel
            // 
            this.WagonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WagonPanel.Controls.Add(this.pictureBox3);
            this.WagonPanel.Controls.Add(this.pictureBox1);
            this.WagonPanel.Controls.Add(this.WagonText);
            this.WagonPanel.Location = new System.Drawing.Point(400, 87);
            this.WagonPanel.Name = "WagonPanel";
            this.WagonPanel.Size = new System.Drawing.Size(111, 108);
            this.WagonPanel.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Gray;
            this.pictureBox3.Location = new System.Drawing.Point(45, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 18);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(0, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 18);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // WagonText
            // 
            this.WagonText.AutoSize = true;
            this.WagonText.Location = new System.Drawing.Point(30, 36);
            this.WagonText.Name = "WagonText";
            this.WagonText.Size = new System.Drawing.Size(53, 17);
            this.WagonText.TabIndex = 0;
            this.WagonText.Text = "Wagon";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox2.Location = new System.Drawing.Point(1, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1024, 24);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Linear mover";
            // 
            // PositionEnabledCheckbox
            // 
            this.PositionEnabledCheckbox.AutoSize = true;
            this.PositionEnabledCheckbox.Location = new System.Drawing.Point(12, 12);
            this.PositionEnabledCheckbox.Name = "PositionEnabledCheckbox";
            this.PositionEnabledCheckbox.Size = new System.Drawing.Size(135, 21);
            this.PositionEnabledCheckbox.TabIndex = 10;
            this.PositionEnabledCheckbox.Text = "Position enabled";
            this.PositionEnabledCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 496);
            this.Controls.Add(this.PositionEnabledCheckbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.WagonPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IniMitteBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IniRechtsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IniLinksBox);
            this.Name = "Form1";
            this.Text = "Automation simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IniLinksBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IniRechtsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IniMitteBox)).EndInit();
            this.WagonPanel.ResumeLayout(false);
            this.WagonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IniLinksBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox IniRechtsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox IniMitteBox;
        private System.Windows.Forms.Panel WagonPanel;
        private System.Windows.Forms.Label WagonText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox PositionEnabledCheckbox;
    }
}

