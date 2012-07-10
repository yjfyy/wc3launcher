namespace WC3Launcher
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.btnGo = new System.Windows.Forms.Button();
            this.chkClearCash = new System.Windows.Forms.CheckBox();
            this.txtGameExePath = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wbNews = new System.Windows.Forms.WebBrowser();
            this.chkLaunchGameOnStart = new System.Windows.Forms.CheckBox();
            this.chkUseOpenGL = new System.Windows.Forms.CheckBox();
            this.chkUseWindowMode = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.linkAdv = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGo.Location = new System.Drawing.Point(353, 320);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(127, 74);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // chkClearCash
            // 
            this.chkClearCash.AutoSize = true;
            this.chkClearCash.Location = new System.Drawing.Point(12, 376);
            this.chkClearCash.Name = "chkClearCash";
            this.chkClearCash.Size = new System.Drawing.Size(152, 17);
            this.chkClearCash.TabIndex = 4;
            this.chkClearCash.Text = "Clear cache (bncache.dat)";
            this.chkClearCash.UseVisualStyleBackColor = true;
            this.chkClearCash.CheckedChanged += new System.EventHandler(this.chkClearCash_CheckedChanged);
            // 
            // txtGameExePath
            // 
            this.txtGameExePath.Location = new System.Drawing.Point(12, 320);
            this.txtGameExePath.Name = "txtGameExePath";
            this.txtGameExePath.ReadOnly = true;
            this.txtGameExePath.Size = new System.Drawing.Size(287, 20);
            this.txtGameExePath.TabIndex = 5;
            this.txtGameExePath.Click += new System.EventHandler(this.txtGameExePath_Click);
            this.txtGameExePath.TextChanged += new System.EventHandler(this.txtGameExePath_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "w3l.exe";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(305, 318);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(29, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wbNews);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 263);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server news";
            // 
            // wbNews
            // 
            this.wbNews.Location = new System.Drawing.Point(6, 19);
            this.wbNews.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbNews.Name = "wbNews";
            this.wbNews.Size = new System.Drawing.Size(457, 238);
            this.wbNews.TabIndex = 3;
            // 
            // chkLaunchGameOnStart
            // 
            this.chkLaunchGameOnStart.AutoSize = true;
            this.chkLaunchGameOnStart.Location = new System.Drawing.Point(12, 353);
            this.chkLaunchGameOnStart.Name = "chkLaunchGameOnStart";
            this.chkLaunchGameOnStart.Size = new System.Drawing.Size(113, 17);
            this.chkLaunchGameOnStart.TabIndex = 9;
            this.chkLaunchGameOnStart.Text = "Run game on start";
            this.chkLaunchGameOnStart.UseVisualStyleBackColor = true;
            this.chkLaunchGameOnStart.CheckedChanged += new System.EventHandler(this.chkLaunchGameOnStart_CheckedChanged);
            // 
            // chkUseOpenGL
            // 
            this.chkUseOpenGL.AutoSize = true;
            this.chkUseOpenGL.Location = new System.Drawing.Point(180, 376);
            this.chkUseOpenGL.Name = "chkUseOpenGL";
            this.chkUseOpenGL.Size = new System.Drawing.Size(88, 17);
            this.chkUseOpenGL.TabIndex = 10;
            this.chkUseOpenGL.Text = "Use OpenGL";
            this.chkUseOpenGL.UseVisualStyleBackColor = true;
            this.chkUseOpenGL.CheckedChanged += new System.EventHandler(this.chkUseOpenGL_CheckedChanged);
            // 
            // chkUseWindowMode
            // 
            this.chkUseWindowMode.AutoSize = true;
            this.chkUseWindowMode.Location = new System.Drawing.Point(180, 354);
            this.chkUseWindowMode.Name = "chkUseWindowMode";
            this.chkUseWindowMode.Size = new System.Drawing.Size(154, 17);
            this.chkUseWindowMode.TabIndex = 11;
            this.chkUseWindowMode.Text = "Run game in window mode";
            this.chkUseWindowMode.UseVisualStyleBackColor = true;
            this.chkUseWindowMode.CheckedChanged += new System.EventHandler(this.chkUseWindowMode_CheckedChanged);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // linkAdv
            // 
            this.linkAdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkAdv.Location = new System.Drawing.Point(18, 5);
            this.linkAdv.Name = "linkAdv";
            this.linkAdv.Size = new System.Drawing.Size(457, 31);
            this.linkAdv.TabIndex = 7;
            this.linkAdv.TabStop = true;
            this.linkAdv.Text = "Advertising link";
            this.linkAdv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkAdv.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdv_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 406);
            this.Controls.Add(this.chkUseWindowMode);
            this.Controls.Add(this.chkUseOpenGL);
            this.Controls.Add(this.chkLaunchGameOnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkAdv);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtGameExePath);
            this.Controls.Add(this.chkClearCash);
            this.Controls.Add(this.btnGo);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarCraft III Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.CheckBox chkClearCash;
        private System.Windows.Forms.TextBox txtGameExePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser wbNews;
        private System.Windows.Forms.CheckBox chkLaunchGameOnStart;
        private System.Windows.Forms.CheckBox chkUseOpenGL;
        private System.Windows.Forms.CheckBox chkUseWindowMode;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.LinkLabel linkAdv;
    }
}

