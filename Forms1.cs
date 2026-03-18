namespace Forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer2.Interval = 1000;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textbox1.Text, out int minutes))
            {
                if (int.TryParse(textbox2.Text, out int seconds))
                {
                    all_seconds = minutes * 60 + seconds;
                    label3.Text = TimeSpan.FromSeconds(all_seconds).ToString(@"mm\:ss");
                }
                else
                {
                    Message.Box.Show("Niepoprawny format czasu");
                    return
                }
            }
        }
    }
}