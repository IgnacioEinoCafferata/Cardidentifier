namespace Card_identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label1.Text = "This is the King of diamond";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "This is the ace of club";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.Text = "This is the ten of diamond";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "This is the seven of heart";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "This is the three of spade";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
