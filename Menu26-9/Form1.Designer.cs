﻿namespace Menu26_9
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.TDTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.HTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GPTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.B1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.B2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HCNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 39);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TDTToolStripMenuItem,
            this.GPTToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 39);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // TDTToolStripMenuItem
            // 
            this.TDTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HCNToolStripMenuItem,
            this.toolStripMenuItem1,
            this.HTToolStripMenuItem});
            this.TDTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDTToolStripMenuItem.Name = "TDTToolStripMenuItem";
            this.TDTToolStripMenuItem.Size = new System.Drawing.Size(167, 35);
            this.TDTToolStripMenuItem.Text = "Tính diện tích";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(243, 6);
            // 
            // HTToolStripMenuItem
            // 
            this.HTToolStripMenuItem.Name = "HTToolStripMenuItem";
            this.HTToolStripMenuItem.Size = new System.Drawing.Size(246, 36);
            this.HTToolStripMenuItem.Text = "Hình tròn";
            this.HTToolStripMenuItem.Click += new System.EventHandler(this.HTToolStripMenuItem_Click);
            // 
            // GPTToolStripMenuItem
            // 
            this.GPTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.B1ToolStripMenuItem,
            this.B2ToolStripMenuItem1});
            this.GPTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPTToolStripMenuItem.Name = "GPTToolStripMenuItem";
            this.GPTToolStripMenuItem.Size = new System.Drawing.Size(210, 35);
            this.GPTToolStripMenuItem.Text = "Giải phương trình";
            // 
            // B1ToolStripMenuItem
            // 
            this.B1ToolStripMenuItem.Name = "B1ToolStripMenuItem";
            this.B1ToolStripMenuItem.Size = new System.Drawing.Size(224, 36);
            this.B1ToolStripMenuItem.Text = "Bậc nhất";
            this.B1ToolStripMenuItem.Click += new System.EventHandler(this.B1ToolStripMenuItem_Click);
            // 
            // B2ToolStripMenuItem1
            // 
            this.B2ToolStripMenuItem1.Name = "B2ToolStripMenuItem1";
            this.B2ToolStripMenuItem1.Size = new System.Drawing.Size(190, 36);
            this.B2ToolStripMenuItem1.Text = "Bậc hai";
            // 
            // HCNToolStripMenuItem
            // 
            this.HCNToolStripMenuItem.Name = "HCNToolStripMenuItem";
            this.HCNToolStripMenuItem.Size = new System.Drawing.Size(246, 36);
            this.HCNToolStripMenuItem.Text = "Hình chữ nhật";
            this.HCNToolStripMenuItem.Click += new System.EventHandler(this.HCNToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem TDTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HCNToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem HTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GPTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem B1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem B2ToolStripMenuItem1;
    }
}

