using System;
using System.Windows.Forms;
using System.Management.Automation;



namespace Win_Otimization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bSystem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Add(checkBox_Firewall);
            splitContainer1.Panel2.Controls.Add(bOkSystem);
            splitContainer1.Panel2.Controls.Add(bResSystem);
        }

        private void CommandPowerShell()
        {

        }

        private void bOkSystem_Click(object sender, EventArgs e) //сюда добавлять все чекбоксы которые будут срабатывать по нажатию кнопки ок во вкладке system
        {
            if (checkBox_Firewall.Checked)
            {
                PowerShell powerShell = PowerShell.Create();
                powerShell.AddCommand("Set-NetFirewallProfile").AddParameter("-Enabled", "False");
                powerShell.Invoke();
                powerShell.Stop();
            }
        }

        private void bResSystem_Click(object sender, EventArgs e) //сюда добавлять все чекбоксы которые будут срабатывать по нажатию кнопки reset во вкладке system
        {
            if (checkBox_Firewall.Checked)
            {
                PowerShell powerShell = PowerShell.Create();
                powerShell.AddCommand("Set-NetFirewallProfile").AddParameter("-Enabled", "True");
                powerShell.Invoke();
                powerShell.Stop();
            }
        }
    }
}
