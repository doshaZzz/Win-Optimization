namespace Win_Optimization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //GO!!!!!
        {
            Form ifrm = new Form2();
            ifrm.Show(); // ���������� Form2
            this.Hide(); // �������� Form1 (this - ������� �����)
        }
    }
}
