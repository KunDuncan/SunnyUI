﻿
namespace Sunny.UI.Demo
{
    partial class FProcess
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
            this.uiBreadcrumb1 = new Sunny.UI.UIBreadcrumb();
            this.uiRoundProcess2 = new Sunny.UI.UIRoundProcess();
            this.uiLine9 = new Sunny.UI.UILine();
            this.uiRoundProcess1 = new Sunny.UI.UIRoundProcess();
            this.uiProcessBar2 = new Sunny.UI.UIProcessBar();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiWaitingBar1 = new Sunny.UI.UIWaitingBar();
            this.uiLine5 = new Sunny.UI.UILine();
            this.uiTrackBar1 = new Sunny.UI.UITrackBar();
            this.uiLine4 = new Sunny.UI.UILine();
            this.uiProgressIndicator1 = new Sunny.UI.UIProgressIndicator();
            this.uiLine3 = new Sunny.UI.UILine();
            this.uiProcessBar1 = new Sunny.UI.UIProcessBar();
            this.uiLine2 = new Sunny.UI.UILine();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.uiLine2);
            this.PagePanel.Controls.Add(this.uiBreadcrumb1);
            this.PagePanel.Controls.Add(this.uiRoundProcess2);
            this.PagePanel.Controls.Add(this.uiLine9);
            this.PagePanel.Controls.Add(this.uiRoundProcess1);
            this.PagePanel.Controls.Add(this.uiProcessBar2);
            this.PagePanel.Controls.Add(this.uiLine1);
            this.PagePanel.Controls.Add(this.uiWaitingBar1);
            this.PagePanel.Controls.Add(this.uiLine5);
            this.PagePanel.Controls.Add(this.uiTrackBar1);
            this.PagePanel.Controls.Add(this.uiLine4);
            this.PagePanel.Controls.Add(this.uiProgressIndicator1);
            this.PagePanel.Controls.Add(this.uiLine3);
            this.PagePanel.Controls.Add(this.uiProcessBar1);
            this.PagePanel.Size = new System.Drawing.Size(1022, 525);
            // 
            // uiBreadcrumb1
            // 
            this.uiBreadcrumb1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiBreadcrumb1.ItemIndex = 2;
            this.uiBreadcrumb1.Items.AddRange(new object[] {
            "步骤一",
            "步骤二",
            "步骤三",
            "步骤四",
            "步骤五"});
            this.uiBreadcrumb1.ItemWidth = 100;
            this.uiBreadcrumb1.Location = new System.Drawing.Point(30, 372);
            this.uiBreadcrumb1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBreadcrumb1.Name = "uiBreadcrumb1";
            this.uiBreadcrumb1.Size = new System.Drawing.Size(588, 29);
            this.uiBreadcrumb1.TabIndex = 73;
            this.uiBreadcrumb1.Text = "uiBreadcrumb1";
            // 
            // uiRoundProcess2
            // 
            this.uiRoundProcess2.BackColor = System.Drawing.Color.Transparent;
            this.uiRoundProcess2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRoundProcess2.ForeColor = System.Drawing.Color.White;
            this.uiRoundProcess2.Inner = 0;
            this.uiRoundProcess2.Location = new System.Drawing.Point(155, 138);
            this.uiRoundProcess2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRoundProcess2.Name = "uiRoundProcess2";
            this.uiRoundProcess2.ShowProcess = true;
            this.uiRoundProcess2.Size = new System.Drawing.Size(120, 120);
            this.uiRoundProcess2.Style = Sunny.UI.UIStyle.Custom;
            this.uiRoundProcess2.StyleCustomMode = true;
            this.uiRoundProcess2.TabIndex = 72;
            this.uiRoundProcess2.Text = "0.0%";
            // 
            // uiLine9
            // 
            this.uiLine9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine9.Location = new System.Drawing.Point(29, 112);
            this.uiLine9.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine9.Name = "uiLine9";
            this.uiLine9.Size = new System.Drawing.Size(319, 20);
            this.uiLine9.TabIndex = 71;
            this.uiLine9.Text = "UIRoundProcess";
            this.uiLine9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiRoundProcess1
            // 
            this.uiRoundProcess1.BackColor = System.Drawing.Color.Transparent;
            this.uiRoundProcess1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRoundProcess1.Location = new System.Drawing.Point(28, 138);
            this.uiRoundProcess1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRoundProcess1.Name = "uiRoundProcess1";
            this.uiRoundProcess1.ShowProcess = true;
            this.uiRoundProcess1.Size = new System.Drawing.Size(120, 120);
            this.uiRoundProcess1.TabIndex = 70;
            this.uiRoundProcess1.Text = "0.0%";
            // 
            // uiProcessBar2
            // 
            this.uiProcessBar2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiProcessBar2.Location = new System.Drawing.Point(30, 88);
            this.uiProcessBar2.MinimumSize = new System.Drawing.Size(70, 1);
            this.uiProcessBar2.Name = "uiProcessBar2";
            this.uiProcessBar2.Size = new System.Drawing.Size(318, 5);
            this.uiProcessBar2.TabIndex = 69;
            this.uiProcessBar2.Text = "50.0%";
            this.uiProcessBar2.Value = 50;
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(381, 20);
            this.uiLine1.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(319, 20);
            this.uiLine1.TabIndex = 68;
            this.uiLine1.Text = "UIWaitingBar";
            this.uiLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiWaitingBar1
            // 
            this.uiWaitingBar1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiWaitingBar1.Location = new System.Drawing.Point(381, 53);
            this.uiWaitingBar1.MinimumSize = new System.Drawing.Size(70, 23);
            this.uiWaitingBar1.Name = "uiWaitingBar1";
            this.uiWaitingBar1.Size = new System.Drawing.Size(319, 29);
            this.uiWaitingBar1.TabIndex = 67;
            this.uiWaitingBar1.Text = "uiWaitingBar1";
            // 
            // uiLine5
            // 
            this.uiLine5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine5.Location = new System.Drawing.Point(30, 264);
            this.uiLine5.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine5.Name = "uiLine5";
            this.uiLine5.Size = new System.Drawing.Size(319, 20);
            this.uiLine5.TabIndex = 66;
            this.uiLine5.Text = "UITrackBar";
            this.uiLine5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTrackBar1
            // 
            this.uiTrackBar1.DisableColor = System.Drawing.Color.Silver;
            this.uiTrackBar1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTrackBar1.Location = new System.Drawing.Point(30, 290);
            this.uiTrackBar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTrackBar1.Name = "uiTrackBar1";
            this.uiTrackBar1.Size = new System.Drawing.Size(158, 29);
            this.uiTrackBar1.TabIndex = 65;
            this.uiTrackBar1.Text = "uiTrackBar1";
            this.uiTrackBar1.Value = 50;
            // 
            // uiLine4
            // 
            this.uiLine4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine4.Location = new System.Drawing.Point(381, 112);
            this.uiLine4.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine4.Name = "uiLine4";
            this.uiLine4.Size = new System.Drawing.Size(319, 20);
            this.uiLine4.TabIndex = 64;
            this.uiLine4.Text = "UIProgressIndicator";
            this.uiLine4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiProgressIndicator1
            // 
            this.uiProgressIndicator1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiProgressIndicator1.Location = new System.Drawing.Point(381, 138);
            this.uiProgressIndicator1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiProgressIndicator1.Name = "uiProgressIndicator1";
            this.uiProgressIndicator1.Size = new System.Drawing.Size(120, 120);
            this.uiProgressIndicator1.TabIndex = 63;
            this.uiProgressIndicator1.Text = "uiProgressIndicator1";
            // 
            // uiLine3
            // 
            this.uiLine3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine3.Location = new System.Drawing.Point(30, 20);
            this.uiLine3.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine3.Name = "uiLine3";
            this.uiLine3.Size = new System.Drawing.Size(319, 20);
            this.uiLine3.TabIndex = 62;
            this.uiLine3.Text = "UIProcessBar";
            this.uiLine3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiProcessBar1
            // 
            this.uiProcessBar1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiProcessBar1.Location = new System.Drawing.Point(30, 53);
            this.uiProcessBar1.MinimumSize = new System.Drawing.Size(70, 1);
            this.uiProcessBar1.Name = "uiProcessBar1";
            this.uiProcessBar1.Size = new System.Drawing.Size(318, 29);
            this.uiProcessBar1.TabIndex = 61;
            this.uiProcessBar1.Text = "50.0%";
            this.uiProcessBar1.Value = 50;
            // 
            // uiLine2
            // 
            this.uiLine2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine2.Location = new System.Drawing.Point(30, 334);
            this.uiLine2.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(319, 20);
            this.uiLine2.TabIndex = 74;
            this.uiLine2.Text = "UIBreadcrumb";
            this.uiLine2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 560);
            this.Name = "FProcess";
            this.Symbol = 62034;
            this.Text = "Progress";
            this.PagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UIBreadcrumb uiBreadcrumb1;
        private UIRoundProcess uiRoundProcess2;
        private UILine uiLine9;
        private UIRoundProcess uiRoundProcess1;
        private UIProcessBar uiProcessBar2;
        private UILine uiLine1;
        private UIWaitingBar uiWaitingBar1;
        private UILine uiLine5;
        private UITrackBar uiTrackBar1;
        private UILine uiLine4;
        private UIProgressIndicator uiProgressIndicator1;
        private UILine uiLine3;
        private UIProcessBar uiProcessBar1;
        private UILine uiLine2;
        private System.Windows.Forms.Timer timer1;
    }
}