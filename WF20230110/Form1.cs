namespace WF20230110
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            _ = new FormColorCha(pB).ShowDialog();

        }
    }
}