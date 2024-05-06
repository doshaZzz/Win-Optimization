namespace Win_Otimization
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bSystem = new System.Windows.Forms.Button();
            this.checkBox_Firewall = new System.Windows.Forms.CheckBox();
            this.bOkSystem = new System.Windows.Forms.Button();
            this.bResSystem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bSystem);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 208;
            this.splitContainer1.TabIndex = 0;
            // 
            // bSystem
            // 
            this.bSystem.Location = new System.Drawing.Point(10, 3);
            this.bSystem.Name = "bSystem";
            this.bSystem.Size = new System.Drawing.Size(184, 23);
            this.bSystem.TabIndex = 0;
            this.bSystem.Text = "System";
            this.bSystem.UseVisualStyleBackColor = true;
            this.bSystem.Click += new System.EventHandler(this.bSystem_Click);
            // 
            // checkBox_Firewall
            // 
            this.checkBox_Firewall.AutoSize = true;
            this.checkBox_Firewall.Location = new System.Drawing.Point(15, 8);
            this.checkBox_Firewall.Name = "checkBox_Firewall";
            this.checkBox_Firewall.Size = new System.Drawing.Size(237, 17);
            this.checkBox_Firewall.TabIndex = 0;
            this.checkBox_Firewall.Text = "Откл. брандбауэра и защитника Windows";
            this.checkBox_Firewall.UseVisualStyleBackColor = true;
            // 
            // bOkSystem
            // 
            this.bOkSystem.Location = new System.Drawing.Point(208, 415);
            this.bOkSystem.Name = "bOkSystem";
            this.bOkSystem.Size = new System.Drawing.Size(75, 23);
            this.bOkSystem.TabIndex = 0;
            this.bOkSystem.Text = "OK";
            this.bOkSystem.UseVisualStyleBackColor = true;
            this.bOkSystem.Click += new System.EventHandler(this.bOkSystem_Click);
            // 
            // bResSystem
            // 
            this.bResSystem.Location = new System.Drawing.Point(387, 415);
            this.bResSystem.Name = "bResSystem";
            this.bResSystem.Size = new System.Drawing.Size(75, 23);
            this.bResSystem.TabIndex = 0;
            this.bResSystem.Text = "Reset";
            this.bResSystem.UseVisualStyleBackColor = true;
            this.bResSystem.Click += new System.EventHandler(this.bResSystem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bSystem;
        private System.Windows.Forms.CheckBox checkBox_Firewall;
        private System.Windows.Forms.Button bOkSystem;
        private System.Windows.Forms.Button bResSystem;
    }
}

