﻿namespace Win_Optimization;

partial class Form2
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
        splitContainer1 = new SplitContainer();
        button1 = new Button();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.SuspendLayout();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.BorderStyle = BorderStyle.Fixed3D;
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(button1);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Size = new Size(1055, 659);
        splitContainer1.SplitterDistance = 325;
        splitContainer1.TabIndex = 0;
        // 
        // button1
        // 
        button1.Location = new Point(3, 3);
        button1.Name = "button1";
        button1.Size = new Size(315, 23);
        button1.TabIndex = 0;
        button1.Text = "Конфиденциальность";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form2
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1055, 659);
        Controls.Add(splitContainer1);
        Name = "Form2";
        Text = "Form2";
        splitContainer1.Panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private SplitContainer splitContainer1;
    private Button button1;
}