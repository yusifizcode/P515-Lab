namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(Loop1);
            thread1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread2 = new Thread(Loop2);
            thread2.Start();
        }

        private void Loop1()
        {
            for (int i = 0; i <= 1000000000; i++)
            {
                progressBar1.Value = i / 10000000;
            }
        }

        private void Loop2()
        {
            for (int i = 0; i <= 1000000000; i++)
            {
                progressBar2.Value = i / 10000000;
            }
        }
    }
}