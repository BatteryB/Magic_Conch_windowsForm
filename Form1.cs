namespace 마법의_소라고동
{
    public partial class Form1 : Form
    {
        private String[] randomTxt = new string[] { "안 돼.", "가만히 있어.", "그것도 안 돼.", "좋아.", "다시 한 번 물어봐.", "전부 안돼." };
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            int randomNum = random.Next(6);
            printLable.Text = randomTxt[randomNum];
        }

        private void printLable_Click(object sender, EventArgs e)
        {

        }
    }
}
