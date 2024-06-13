namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime bday = Convert.ToDateTime(textBox1.Text);
            DateTime today = DateTime.Today;

            int bdayd = bday.Day;
            int bdayy = bday.Year;
            int bdaym = bday.Month;
            int todayd = today.Day;
            int todayy = today.Year;
            int todaym = today.Month;

            if (todayd < bdayd)
            {
                todayd += 30;
                todaym -= 1;
            }

            if (todaym < bdaym)
            {
                todaym += 12;
                todayy -= 1;
            }

            int day = todayd - bdayd;
            int month = todaym - bdaym;
            int year = todayy - bdayy;

            MessageBox.Show(year + "yýl" + month + "ay" + day + "gün");
        }
    }
}
