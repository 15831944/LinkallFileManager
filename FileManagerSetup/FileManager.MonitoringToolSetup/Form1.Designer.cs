﻿namespace FileManager.MonitoringToolSetup
{
    partial class Form1
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
            this.textBox_tipMsg = new System.Windows.Forms.TextBox();
            this.button_serviceUnintall = new System.Windows.Forms.Button();
            this.button_serviceClose = new System.Windows.Forms.Button();
            this.button_serviceOpen = new System.Windows.Forms.Button();
            this.button_serviceIntall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_tipMsg
            // 
            this.textBox_tipMsg.BackColor = System.Drawing.Color.Black;
            this.textBox_tipMsg.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_tipMsg.ForeColor = System.Drawing.Color.Lime;
            this.textBox_tipMsg.Location = new System.Drawing.Point(18, 76);
            this.textBox_tipMsg.Multiline = true;
            this.textBox_tipMsg.Name = "textBox_tipMsg";
            this.textBox_tipMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_tipMsg.Size = new System.Drawing.Size(436, 189);
            this.textBox_tipMsg.TabIndex = 9;
            // 
            // button_serviceUnintall
            // 
            this.button_serviceUnintall.Location = new System.Drawing.Point(131, 21);
            this.button_serviceUnintall.Name = "button_serviceUnintall";
            this.button_serviceUnintall.Size = new System.Drawing.Size(89, 38);
            this.button_serviceUnintall.TabIndex = 8;
            this.button_serviceUnintall.Text = "监控卸载";
            this.button_serviceUnintall.UseVisualStyleBackColor = true;
            this.button_serviceUnintall.Click += new System.EventHandler(this.button_serviceUnintall_Click);
            // 
            // button_serviceClose
            // 
            this.button_serviceClose.Location = new System.Drawing.Point(365, 21);
            this.button_serviceClose.Name = "button_serviceClose";
            this.button_serviceClose.Size = new System.Drawing.Size(89, 38);
            this.button_serviceClose.TabIndex = 7;
            this.button_serviceClose.Text = "监控停止";
            this.button_serviceClose.UseVisualStyleBackColor = true;
            this.button_serviceClose.Click += new System.EventHandler(this.button_serviceClose_Click);
            // 
            // button_serviceOpen
            // 
            this.button_serviceOpen.Location = new System.Drawing.Point(244, 21);
            this.button_serviceOpen.Name = "button_serviceOpen";
            this.button_serviceOpen.Size = new System.Drawing.Size(89, 38);
            this.button_serviceOpen.TabIndex = 6;
            this.button_serviceOpen.Text = "监控开启";
            this.button_serviceOpen.UseVisualStyleBackColor = true;
            this.button_serviceOpen.Click += new System.EventHandler(this.button_serviceOpen_Click);
            // 
            // button_serviceIntall
            // 
            this.button_serviceIntall.Location = new System.Drawing.Point(18, 21);
            this.button_serviceIntall.Name = "button_serviceIntall";
            this.button_serviceIntall.Size = new System.Drawing.Size(89, 38);
            this.button_serviceIntall.TabIndex = 5;
            this.button_serviceIntall.Text = "监控安装";
            this.button_serviceIntall.UseVisualStyleBackColor = true;
            this.button_serviceIntall.Click += new System.EventHandler(this.button_serviceIntall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 277);
            this.Controls.Add(this.textBox_tipMsg);
            this.Controls.Add(this.button_serviceUnintall);
            this.Controls.Add(this.button_serviceClose);
            this.Controls.Add(this.button_serviceOpen);
            this.Controls.Add(this.button_serviceIntall);
            this.Name = "Form1";
            this.Text = "监控服务安装";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_tipMsg;
        private System.Windows.Forms.Button button_serviceUnintall;
        private System.Windows.Forms.Button button_serviceClose;
        private System.Windows.Forms.Button button_serviceOpen;
        private System.Windows.Forms.Button button_serviceIntall;
    }
}

