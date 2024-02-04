namespace Breakout
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(difficultycomboBox.Text))
            {
                Breakout breakout = new Breakout(difficultycomboBox.Text);
                this.Hide();
                breakout.Show();
            }
            else
            {
                MessageBox.Show("Please choose a difficulty!");
            }


        }
    }
}
