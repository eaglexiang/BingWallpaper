namespace 必应壁纸
{
    partial class CopyInfo
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
            this.label_Info = new System.Windows.Forms.Label();
            this.label_Copy = new System.Windows.Forms.Label();
            this.label_Cancel = new System.Windows.Forms.Label();
            this.label_BG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Info.Location = new System.Drawing.Point(12, 9);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(45, 17);
            this.label_Info.TabIndex = 0;
            this.label_Info.Text = "label1";
            this.label_Info.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Info_MouseDown);
            // 
            // label_Copy
            // 
            this.label_Copy.BackColor = System.Drawing.SystemColors.Control;
            this.label_Copy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Copy.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Copy.Location = new System.Drawing.Point(24, 58);
            this.label_Copy.Name = "label_Copy";
            this.label_Copy.Size = new System.Drawing.Size(103, 23);
            this.label_Copy.TabIndex = 8;
            this.label_Copy.Text = "复制";
            this.label_Copy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Copy.Click += new System.EventHandler(this.label_Copy_Click);
            this.label_Copy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_MouseDown);
            this.label_Copy.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label_Copy.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.label_Copy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_MouseUp);
            // 
            // label_Cancel
            // 
            this.label_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.label_Cancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Cancel.Location = new System.Drawing.Point(133, 58);
            this.label_Cancel.Name = "label_Cancel";
            this.label_Cancel.Size = new System.Drawing.Size(103, 23);
            this.label_Cancel.TabIndex = 9;
            this.label_Cancel.Text = "取消";
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
            this.label_BG.Location = new System.Drawing.Point(9, 12);
            this.label_BG.Name = "label_BG";
            this.label_BG.Size = new System.Drawing.Size(137, 23);
            this.label_BG.TabIndex = 10;
            this.label_BG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_BG_MouseDown);
            // 
            // CopyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(245, 90);
            this.ControlBox = false;
            this.Controls.Add(this.label_Cancel);
            this.Controls.Add(this.label_Copy);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.label_BG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CopyInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CopyInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Label label_Copy;
        private System.Windows.Forms.Label label_Cancel;
        private System.Windows.Forms.Label label_BG;
    }
}