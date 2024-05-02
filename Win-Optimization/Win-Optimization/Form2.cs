namespace Win_Optimization
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 
            // checkBox1
            // 
            // Create and initialize a CheckBox.   
            CheckBox checkBox1 = new CheckBox();
            // Make the check box control appear as a toggle button.
            //checkBox2.Appearance = Appearance.Button;
            // Turn off the update of the display on the click of the control.
            checkBox1.AutoCheck = false;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(1, 1);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            CheckBox checkBox2 = new CheckBox();
            // Make the check box control appear as a toggle button.
            //checkBox2.Appearance = Appearance.Button;
            // Turn off the update of the display on the click of the control.
            checkBox2.AutoCheck = false;
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(4, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            CheckBox checkBox3 = new CheckBox();
            // Make the check box control appear as a toggle button.
            //checkBox2.Appearance = Appearance.Button;
            // Turn off the update of the display on the click of the control.
            checkBox3.AutoCheck = false;
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(8, 8);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            CheckBox checkBox4 = new CheckBox();
            // Make the check box control appear as a toggle button.
            //checkBox2.Appearance = Appearance.Button;
            // Turn off the update of the display on the click of the control.
            checkBox4.AutoCheck = false;
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(12, 12);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(83, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;

            // Add the check box control to the form.
            splitContainer1.Panel2.Controls.Add(checkBox1);
            splitContainer1.Panel2.Controls.Add(checkBox2);
            splitContainer1.Panel2.Controls.Add(checkBox3);
            splitContainer1.Panel2.Controls.Add(checkBox4);
        }
    }
}
