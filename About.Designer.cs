namespace 必应壁纸
{
    partial class About
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
            this.label_About = new System.Windows.Forms.Label();
            this.linkLabel_Contact = new System.Windows.Forms.LinkLabel();
            this.label_Cancel = new System.Windows.Forms.Label();
            this.label_BG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_About
            // 
            this.label_About.AutoSize = true;
            this.label_About.BackColor = System.Drawing.Color.Transparent;
            this.label_About.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_About.Location = new System.Drawing.Point(29, 17);
            this.label_About.Name = "label_About";
            this.label_About.Size = new System.Drawing.Size(50, 20);
            this.label_About.TabIndex = 0;
            this.label_About.Text = "label1";
            this.label_About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_About.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_About_MouseDown);
            // 
            // linkLabel_Contact
            // 
            this.linkLabel_Contact.AutoSize = true;
            this.linkLabel_Contact.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_Contact.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_Contact.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel_Contact.Location = new System.Drawing.Point(59, 102);
            this.linkLabel_Contact.Name = "linkLabel_Contact";
            this.linkLabel_Contact.Size = new System.Drawing.Size(56, 17);
            this.linkLabel_Contact.TabIndex = 1;
            this.linkLabel_Contact.TabStop = true;
            this.linkLabel_Contact.Text = "访问主页";
            this.linkLabel_Contact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_Contact.UseMnemonic = false;
            this.linkLabel_Contact.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel_Contact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Contact_LinkClicked);
            // 
            // label_Cancel
            // 
            this.label_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.label_Cancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Cancel.Location = new System.Drawing.Point(36, 131);
            this.label_Cancel.Name = "label_Cancel";
            this.label_Cancel.Size = new System.Drawing.Size(103, 23);
            this.label_Cancel.TabIndex = 10;
            this.label_Cancel.Text = "确定";
            this.label_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Cancel.Click += new System.EventHandler(this.label_Cancel_Click);
            this.label_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_MouseDown);
            this.label_Cancel.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label_Cancel.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.label_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_MouseUp);
            // 
            // label_BG
            // 
            this.label_BG.BackColor = System.Drawing.SystemColors.Control;
            this.label_BG.Location = new System.Drawing.Point(12, 17);
            this.label_BG.Name = "label_BG";
            this.label_BG.Size = new System.Drawing.Size(150, 37);
            this.label_BG.TabIndex = 11;
            this.label_BG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_BG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_BG_MouseDown);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(174, 163);
            this.ControlBox = false;
            this.Controls.Add(this.label_Cancel);
            this.Controls.Add(this.linkLabel_Contact);
            this.Controls.Add(this.label_About);
            this.Controls.Add(this.label_BG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_About;
        private System.Windows.Forms.LinkLabel linkLabel_Contact;
        private System.Windows.Forms.Label label_Cancel;
        private System.Windows.Forms.Label label_BG;
    }
}