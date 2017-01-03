namespace 必应壁纸
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.label_Path = new System.Windows.Forms.Label();
            this.label_Download = new System.Windows.Forms.Label();
            this.label_ChooseFolder = new System.Windows.Forms.Label();
            this.label_Wallpaper = new System.Windows.Forms.Label();
            this.label_Exit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.图片信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检查更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.懒人助手ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.优先图片信息命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置壁纸收藏目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于作者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.必应中国ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timer_Load = new System.Windows.Forms.Timer(this.components);
            this.richTextBox_Logs = new System.Windows.Forms.RichTextBox();
            this.timer_Refresh = new System.Windows.Forms.Timer(this.components);
            this.label_Progress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Path
            // 
            this.label_Path.AutoEllipsis = true;
            this.label_Path.BackColor = System.Drawing.SystemColors.Control;
            this.label_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Path.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Path.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Path.Location = new System.Drawing.Point(139, 12);
            this.label_Path.Name = "label_Path";
            this.label_Path.Size = new System.Drawing.Size(216, 23);
            this.label_Path.TabIndex = 5;
            this.label_Path.Text = "请稍候...";
            this.label_Path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Path.UseCompatibleTextRendering = true;
            this.label_Path.Click += new System.EventHandler(this.label_ChooseFolder_Click);
            this.label_Path.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_MouseDown);
            this.label_Path.MouseEnter += new System.EventHandler(this.label_Path_MouseEnter);
            this.label_Path.MouseLeave += new System.EventHandler(this.label_Path_MouseLeave);
            this.label_Path.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_MouseUp);
            this.label_Path.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.myKeyDown);
            // 
            // label_Download
            // 
            this.label_Download.BackColor = System.Drawing.SystemColors.Control;
            this.label_Download.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Download.Enabled = false;
            this.label_Download.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Download.Location = new System.Drawing.Point(12, 12);
            this.label_Download.Name = "label_Download";
            this.label_Download.Size = new System.Drawing.Size(121, 23);
            this.label_Download.TabIndex = 6;
            this.label_Download.Text = "收藏图片";
            this.label_Download.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Download.Click += new System.EventHandler(this.label_Download_Click);
            this.label_Download.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_MouseDown);
            this.label_Download.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label_Download.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.label_Download.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_MouseUp);
            this.label_Download.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.myKeyDown);
            // 
            // label_ChooseFolder
            // 
            this.label_ChooseFolder.BackColor = System.Drawing.SystemColors.Control;
            this.label_ChooseFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ChooseFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ChooseFolder.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ChooseFolder.Location = new System.Drawing.Point(252, 41);
            this.label_ChooseFolder.Name = "label_ChooseFolder";
            this.label_ChooseFolder.Size = new System.Drawing.Size(103, 23);
            this.label_ChooseFolder.TabIndex = 7;
            this.label_ChooseFolder.Text = "打开收藏目录";
            this.label_ChooseFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ChooseFolder.Click += new System.EventHandler(this.label_Path_Click);
            this.label_ChooseFolder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_MouseDown);
            this.label_ChooseFolder.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label_ChooseFolder.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.label_ChooseFolder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_MouseUp);
            this.label_ChooseFolder.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.myKeyDown);
            // 
            // label_Wallpaper
            // 
            this.label_Wallpaper.BackColor = System.Drawing.SystemColors.Control;
            this.label_Wallpaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Wallpaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Wallpaper.Enabled = false;
            this.label_Wallpaper.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Wallpaper.Location = new System.Drawing.Point(12, 41);
            this.label_Wallpaper.Name = "label_Wallpaper";
            this.label_Wallpaper.Size = new System.Drawing.Size(121, 23);
            this.label_Wallpaper.TabIndex = 8;
            this.label_Wallpaper.Text = "设为桌面";
            this.label_Wallpaper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Wallpaper.Click += new System.EventHandler(this.label_Wallpaper_Click);
            this.label_Wallpaper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_MouseDown);
            this.label_Wallpaper.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label_Wallpaper.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.label_Wallpaper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_MouseUp);
            this.label_Wallpaper.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.myKeyDown);
            // 
            // label_Exit
            // 
            this.label_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.label_Exit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Exit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Exit.Location = new System.Drawing.Point(139, 41);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(103, 23);
            this.label_Exit.TabIndex = 9;
            this.label_Exit.Text = "取消";
            this.label_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            this.label_Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_MouseDown);
            this.label_Exit.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label_Exit.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.label_Exit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_MouseUp);
            this.label_Exit.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.myKeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.myKeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图片信息ToolStripMenuItem,
            this.检查更新ToolStripMenuItem,
            this.懒人助手ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.关于ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 114);
            // 
            // 图片信息ToolStripMenuItem
            // 
            this.图片信息ToolStripMenuItem.Enabled = false;
            this.图片信息ToolStripMenuItem.Name = "图片信息ToolStripMenuItem";
            this.图片信息ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.图片信息ToolStripMenuItem.Text = "图片信息";
            this.图片信息ToolStripMenuItem.Click += new System.EventHandler(this.图片信息ToolStripMenuItem_Click);
            // 
            // 检查更新ToolStripMenuItem
            // 
            this.检查更新ToolStripMenuItem.Name = "检查更新ToolStripMenuItem";
            this.检查更新ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.检查更新ToolStripMenuItem.Text = "检查更新";
            this.检查更新ToolStripMenuItem.Click += new System.EventHandler(this.检查更新ToolStripMenuItem_Click);
            // 
            // 懒人助手ToolStripMenuItem
            // 
            this.懒人助手ToolStripMenuItem.Name = "懒人助手ToolStripMenuItem";
            this.懒人助手ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.懒人助手ToolStripMenuItem.Text = "懒人助手";
            this.懒人助手ToolStripMenuItem.Click += new System.EventHandler(this.懒人助手ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.优先图片信息命名ToolStripMenuItem,
            this.设置壁纸收藏目录ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.toolStripMenuItem1.Text = "设置";
            // 
            // 优先图片信息命名ToolStripMenuItem
            // 
            this.优先图片信息命名ToolStripMenuItem.Enabled = false;
            this.优先图片信息命名ToolStripMenuItem.Name = "优先图片信息命名ToolStripMenuItem";
            this.优先图片信息命名ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.优先图片信息命名ToolStripMenuItem.Text = "优先图片信息命名";
            // 
            // 设置壁纸收藏目录ToolStripMenuItem
            // 
            this.设置壁纸收藏目录ToolStripMenuItem.Name = "设置壁纸收藏目录ToolStripMenuItem";
            this.设置壁纸收藏目录ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.设置壁纸收藏目录ToolStripMenuItem.Text = "设置壁纸收藏目录";
            this.设置壁纸收藏目录ToolStripMenuItem.Click += new System.EventHandler(this.label_ChooseFolder_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于作者ToolStripMenuItem,
            this.必应中国ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.关于ToolStripMenuItem.Text = "帮助";
            // 
            // 关于作者ToolStripMenuItem
            // 
            this.关于作者ToolStripMenuItem.Name = "关于作者ToolStripMenuItem";
            this.关于作者ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于作者ToolStripMenuItem.Text = "关于";
            this.关于作者ToolStripMenuItem.Click += new System.EventHandler(this.关于作者ToolStripMenuItem_Click);
            // 
            // 必应中国ToolStripMenuItem
            // 
            this.必应中国ToolStripMenuItem.Name = "必应中国ToolStripMenuItem";
            this.必应中国ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.必应中国ToolStripMenuItem.Text = "必应中国";
            this.必应中国ToolStripMenuItem.Click += new System.EventHandler(this.必应中国ToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 185);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(364, 21);
            this.webBrowser1.TabIndex = 10;
            this.webBrowser1.TabStop = false;
            this.webBrowser1.Url = new System.Uri("http://cn.bing.com/", System.UriKind.Absolute);
            this.webBrowser1.Visible = false;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            this.webBrowser1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.myKeyDown);
            // 
            // timer_Load
            // 
            this.timer_Load.Enabled = true;
            this.timer_Load.Interval = 1000;
            this.timer_Load.Tick += new System.EventHandler(this.timer_Load_Tick);
            // 
            // richTextBox_Logs
            // 
            this.richTextBox_Logs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox_Logs.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_Logs.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox_Logs.Location = new System.Drawing.Point(0, 110);
            this.richTextBox_Logs.Name = "richTextBox_Logs";
            this.richTextBox_Logs.ReadOnly = true;
            this.richTextBox_Logs.Size = new System.Drawing.Size(364, 96);
            this.richTextBox_Logs.TabIndex = 11;
            this.richTextBox_Logs.Text = "";
            this.richTextBox_Logs.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.myKeyDown);
            // 
            // timer_Refresh
            // 
            this.timer_Refresh.Interval = 60000;
            this.timer_Refresh.Tick += new System.EventHandler(this.timer_Refresh_Tick);
            // 
            // label_Progress
            // 
            this.label_Progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_Progress.Location = new System.Drawing.Point(0, 196);
            this.label_Progress.Name = "label_Progress";
            this.label_Progress.Size = new System.Drawing.Size(364, 10);
            this.label_Progress.TabIndex = 12;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(364, 206);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label_Progress);
            this.Controls.Add(this.label_Exit);
            this.Controls.Add(this.label_Wallpaper);
            this.Controls.Add(this.label_ChooseFolder);
            this.Controls.Add(this.label_Download);
            this.Controls.Add(this.label_Path);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.richTextBox_Logs);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 245);
            this.MinimumSize = new System.Drawing.Size(380, 245);
            this.Name = "Form_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加载中...";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.myKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Path;
        private System.Windows.Forms.Label label_Download;
        private System.Windows.Forms.Label label_ChooseFolder;
        private System.Windows.Forms.Label label_Wallpaper;
        private System.Windows.Forms.Label label_Exit;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 懒人助手ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于作者ToolStripMenuItem;
        private System.Windows.Forms.Timer timer_Load;
        private System.Windows.Forms.ToolStripMenuItem 图片信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检查更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 必应中国ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 优先图片信息命名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置壁纸收藏目录ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox_Logs;
        private System.Windows.Forms.Timer timer_Refresh;
        private System.Windows.Forms.Label label_Progress;
    }
}

