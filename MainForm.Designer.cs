﻿namespace ChartLabFramework {
  partial class MainForm {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveInitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.FuncLabel = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.RCoefLabel = new System.Windows.Forms.Label();
      this.YLabel = new System.Windows.Forms.Label();
      this.LowBorderLabel = new System.Windows.Forms.Label();
      this.HighBorderLabel = new System.Windows.Forms.Label();
      this.RCoefData = new System.Windows.Forms.TextBox();
      this.YData = new System.Windows.Forms.TextBox();
      this.LowBorderData = new System.Windows.Forms.TextBox();
      this.HighBorderData = new System.Windows.Forms.TextBox();
      this.DrawBtn = new System.Windows.Forms.Button();
      this.StepLabel = new System.Windows.Forms.Label();
      this.StepData = new System.Windows.Forms.TextBox();
      this.FuncChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.TableBtn = new System.Windows.Forms.Button();
      this.menuStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.FuncChart)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
      this.menuStrip.Size = new System.Drawing.Size(828, 24);
      this.menuStrip.TabIndex = 0;
      this.menuStrip.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveInitToolStripMenuItem,
            this.saveResultToolStripMenuItem,
            this.openFileToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // saveInitToolStripMenuItem
      // 
      this.saveInitToolStripMenuItem.Name = "saveInitToolStripMenuItem";
      this.saveInitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
      this.saveInitToolStripMenuItem.Text = "Save Initial";
      // 
      // saveResultToolStripMenuItem
      // 
      this.saveResultToolStripMenuItem.Name = "saveResultToolStripMenuItem";
      this.saveResultToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
      this.saveResultToolStripMenuItem.Text = "Save Result";
      // 
      // openFileToolStripMenuItem
      // 
      this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
      this.openFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
      this.openFileToolStripMenuItem.Text = "Open File";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
      this.aboutToolStripMenuItem.Text = "About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // FuncLabel
      // 
      this.FuncLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.FuncLabel.AutoSize = true;
      this.FuncLabel.Location = new System.Drawing.Point(567, 31);
      this.FuncLabel.Name = "FuncLabel";
      this.FuncLabel.Size = new System.Drawing.Size(51, 13);
      this.FuncLabel.TabIndex = 1;
      this.FuncLabel.Text = "Function:";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(618, 31);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(198, 43);
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // RCoefLabel
      // 
      this.RCoefLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.RCoefLabel.AutoSize = true;
      this.RCoefLabel.Location = new System.Drawing.Point(615, 106);
      this.RCoefLabel.Name = "RCoefLabel";
      this.RCoefLabel.Size = new System.Drawing.Size(16, 13);
      this.RCoefLabel.TabIndex = 3;
      this.RCoefLabel.Text = "r :";
      // 
      // YLabel
      // 
      this.YLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.YLabel.AutoSize = true;
      this.YLabel.Location = new System.Drawing.Point(613, 141);
      this.YLabel.Name = "YLabel";
      this.YLabel.Size = new System.Drawing.Size(18, 13);
      this.YLabel.TabIndex = 4;
      this.YLabel.Text = "y :";
      // 
      // LowBorderLabel
      // 
      this.LowBorderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.LowBorderLabel.AutoSize = true;
      this.LowBorderLabel.Location = new System.Drawing.Point(571, 172);
      this.LowBorderLabel.Name = "LowBorderLabel";
      this.LowBorderLabel.Size = new System.Drawing.Size(63, 13);
      this.LowBorderLabel.TabIndex = 5;
      this.LowBorderLabel.Text = "Low border:";
      // 
      // HighBorderLabel
      // 
      this.HighBorderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.HighBorderLabel.AutoSize = true;
      this.HighBorderLabel.Location = new System.Drawing.Point(571, 205);
      this.HighBorderLabel.Name = "HighBorderLabel";
      this.HighBorderLabel.Size = new System.Drawing.Size(65, 13);
      this.HighBorderLabel.TabIndex = 6;
      this.HighBorderLabel.Text = "High border:";
      // 
      // RCoefData
      // 
      this.RCoefData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.RCoefData.Location = new System.Drawing.Point(651, 103);
      this.RCoefData.Name = "RCoefData";
      this.RCoefData.Size = new System.Drawing.Size(86, 20);
      this.RCoefData.TabIndex = 7;
      // 
      // YData
      // 
      this.YData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.YData.Location = new System.Drawing.Point(651, 138);
      this.YData.Name = "YData";
      this.YData.Size = new System.Drawing.Size(86, 20);
      this.YData.TabIndex = 8;
      // 
      // LowBorderData
      // 
      this.LowBorderData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.LowBorderData.Location = new System.Drawing.Point(651, 170);
      this.LowBorderData.Name = "LowBorderData";
      this.LowBorderData.Size = new System.Drawing.Size(86, 20);
      this.LowBorderData.TabIndex = 9;
      // 
      // HighBorderData
      // 
      this.HighBorderData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.HighBorderData.Location = new System.Drawing.Point(651, 203);
      this.HighBorderData.Name = "HighBorderData";
      this.HighBorderData.Size = new System.Drawing.Size(86, 20);
      this.HighBorderData.TabIndex = 10;
      // 
      // DrawBtn
      // 
      this.DrawBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.DrawBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.DrawBtn.Location = new System.Drawing.Point(570, 284);
      this.DrawBtn.Name = "DrawBtn";
      this.DrawBtn.Size = new System.Drawing.Size(92, 33);
      this.DrawBtn.TabIndex = 11;
      this.DrawBtn.Text = "Draw chart";
      this.DrawBtn.UseVisualStyleBackColor = true;
      this.DrawBtn.Click += new System.EventHandler(this.DrawBtn_Click);
      // 
      // StepLabel
      // 
      this.StepLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.StepLabel.AutoSize = true;
      this.StepLabel.Location = new System.Drawing.Point(608, 238);
      this.StepLabel.Name = "StepLabel";
      this.StepLabel.Size = new System.Drawing.Size(32, 13);
      this.StepLabel.TabIndex = 12;
      this.StepLabel.Text = "Step:";
      // 
      // StepData
      // 
      this.StepData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.StepData.Location = new System.Drawing.Point(651, 236);
      this.StepData.Name = "StepData";
      this.StepData.Size = new System.Drawing.Size(86, 20);
      this.StepData.TabIndex = 13;
      // 
      // FuncChart
      // 
      this.FuncChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      chartArea2.Name = "ChartArea1";
      this.FuncChart.ChartAreas.Add(chartArea2);
      this.FuncChart.Cursor = System.Windows.Forms.Cursors.Default;
      this.FuncChart.Location = new System.Drawing.Point(24, 45);
      this.FuncChart.Name = "FuncChart";
      this.FuncChart.Size = new System.Drawing.Size(541, 389);
      this.FuncChart.TabIndex = 14;
      this.FuncChart.Text = "FuncChart";
      // 
      // TableBtn
      // 
      this.TableBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.TableBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TableBtn.Location = new System.Drawing.Point(707, 284);
      this.TableBtn.Name = "TableBtn";
      this.TableBtn.Size = new System.Drawing.Size(92, 33);
      this.TableBtn.TabIndex = 15;
      this.TableBtn.Text = "Show table";
      this.TableBtn.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Window;
      this.ClientSize = new System.Drawing.Size(828, 483);
      this.Controls.Add(this.TableBtn);
      this.Controls.Add(this.FuncChart);
      this.Controls.Add(this.StepData);
      this.Controls.Add(this.StepLabel);
      this.Controls.Add(this.DrawBtn);
      this.Controls.Add(this.HighBorderData);
      this.Controls.Add(this.LowBorderData);
      this.Controls.Add(this.YData);
      this.Controls.Add(this.RCoefData);
      this.Controls.Add(this.HighBorderLabel);
      this.Controls.Add(this.LowBorderLabel);
      this.Controls.Add(this.YLabel);
      this.Controls.Add(this.RCoefLabel);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.FuncLabel);
      this.Controls.Add(this.menuStrip);
      this.MainMenuStrip = this.menuStrip;
      this.Name = "MainForm";
      this.Text = "ChartLab";
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.FuncChart)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveInitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveResultToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
    private System.Windows.Forms.Label FuncLabel;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label RCoefLabel;
    private System.Windows.Forms.Label YLabel;
    private System.Windows.Forms.Label LowBorderLabel;
    private System.Windows.Forms.Label HighBorderLabel;
    private System.Windows.Forms.TextBox RCoefData;
    private System.Windows.Forms.TextBox YData;
    private System.Windows.Forms.TextBox LowBorderData;
    private System.Windows.Forms.TextBox HighBorderData;
    private System.Windows.Forms.Button DrawBtn;
    private System.Windows.Forms.Label StepLabel;
    private System.Windows.Forms.TextBox StepData;
    private System.Windows.Forms.DataVisualization.Charting.Chart FuncChart;
    private System.Windows.Forms.Button TableBtn;
  }
}
