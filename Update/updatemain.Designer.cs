namespace Update
{
    partial class updatemain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updatemain));
            this.updateyumiko = new CCWin.SkinControl.SkinButton();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.ready2 = new System.Windows.Forms.Label();
            this.ready1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.noupdate = new CCWin.SkinControl.SkinButton();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.prog = new CCWin.SkinControl.SkinProgressBar();
            this.skinGroupBox1.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateyumiko
            // 
            this.updateyumiko.BackColor = System.Drawing.Color.Transparent;
            this.updateyumiko.BaseColor = System.Drawing.Color.LightSeaGreen;
            this.updateyumiko.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.updateyumiko.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.updateyumiko.DownBack = null;
            this.updateyumiko.ForeColor = System.Drawing.Color.LavenderBlush;
            this.updateyumiko.Location = new System.Drawing.Point(244, 158);
            this.updateyumiko.MouseBack = null;
            this.updateyumiko.Name = "updateyumiko";
            this.updateyumiko.NormlBack = null;
            this.updateyumiko.Size = new System.Drawing.Size(111, 31);
            this.updateyumiko.TabIndex = 18;
            this.updateyumiko.Text = "下载更新";
            this.updateyumiko.UseVisualStyleBackColor = false;
            this.updateyumiko.Click += new System.EventHandler(this.updateyumiko_Click);
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.PeachPuff;
            this.skinGroupBox1.Controls.Add(this.ready2);
            this.skinGroupBox1.Controls.Add(this.ready1);
            this.skinGroupBox1.Controls.Add(this.label8);
            this.skinGroupBox1.Controls.Add(this.label9);
            this.skinGroupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.skinGroupBox1.Location = new System.Drawing.Point(7, 143);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(216, 85);
            this.skinGroupBox1.TabIndex = 17;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "版本";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // ready2
            // 
            this.ready2.AutoSize = true;
            this.ready2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ready2.ForeColor = System.Drawing.Color.Tomato;
            this.ready2.Location = new System.Drawing.Point(117, 45);
            this.ready2.Name = "ready2";
            this.ready2.Size = new System.Drawing.Size(25, 17);
            this.ready2.TabIndex = 11;
            this.ready2.Text = "1.2";
            // 
            // ready1
            // 
            this.ready1.AutoSize = true;
            this.ready1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ready1.ForeColor = System.Drawing.Color.Tomato;
            this.ready1.Location = new System.Drawing.Point(117, 23);
            this.ready1.Name = "ready1";
            this.ready1.Size = new System.Drawing.Size(25, 17);
            this.ready1.TabIndex = 10;
            this.ready1.Text = "1.1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.BlueViolet;
            this.label8.Location = new System.Drawing.Point(32, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "当前版本";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.BlueViolet;
            this.label9.Location = new System.Drawing.Point(32, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "最新版本";
            // 
            // noupdate
            // 
            this.noupdate.BackColor = System.Drawing.Color.Transparent;
            this.noupdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.noupdate.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.noupdate.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.noupdate.DownBack = null;
            this.noupdate.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.noupdate.ForeColor = System.Drawing.Color.BlueViolet;
            this.noupdate.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.noupdate.Location = new System.Drawing.Point(244, 191);
            this.noupdate.MouseBack = null;
            this.noupdate.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.noupdate.Name = "noupdate";
            this.noupdate.NormlBack = null;
            this.noupdate.Size = new System.Drawing.Size(111, 29);
            this.noupdate.TabIndex = 21;
            this.noupdate.Text = "暂不更新";
            this.noupdate.UseVisualStyleBackColor = false;
            // 
            // skinPanel1
            // 
            this.skinPanel1.AutoScroll = true;
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(9, 31);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(346, 100);
            this.skinPanel1.TabIndex = 22;
            // 
            // skinLabel1
            // 
            this.skinLabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Forme;
            this.skinLabel1.AutoEllipsis = true;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(4, 4);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(210, 85);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "2019年3月27日\r\n版本@1.2\r\n1.修复了上一版本可能产生的线程问题\r\n2.修复消息框弹出的某些问题\r\n3.优化了程序的性能";
            this.skinLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prog
            // 
            this.prog.Back = null;
            this.prog.BackColor = System.Drawing.Color.Transparent;
            this.prog.BarBack = null;
            this.prog.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.prog.ForeColor = System.Drawing.Color.PapayaWhip;
            this.prog.Location = new System.Drawing.Point(9, 246);
            this.prog.Name = "prog";
            this.prog.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.prog.Size = new System.Drawing.Size(346, 27);
            this.prog.TabIndex = 23;
            this.prog.TrackBack = System.Drawing.Color.IndianRed;
            this.prog.TrackFore = System.Drawing.Color.RoyalBlue;
            this.prog.Value = 30;
            // 
            // updatemain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 288);
            this.Controls.Add(this.prog);
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.noupdate);
            this.Controls.Add(this.updateyumiko);
            this.Controls.Add(this.skinGroupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "updatemain";
            this.Text = "更新YumikoAmine";
            this.TitleSuitColor = true;
            this.Load += new System.EventHandler(this.updatemain_Load);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton updateyumiko;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private System.Windows.Forms.Label ready2;
        private System.Windows.Forms.Label ready1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private CCWin.SkinControl.SkinButton noupdate;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinProgressBar prog;
    }
}

