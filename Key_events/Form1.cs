using System.Media;

namespace Key_events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text += e.KeyChar;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label2.Text = "Düyməyə basdınız";
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label2.Text = "Düyməyə buraxdınız";
        }
        SoundPlayer s = new SoundPlayer("D:\\C# dersleri\\img and details\\buttonsound.wav");
        private void Form1_Load(object sender, EventArgs e)
        {
            //s.Play();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            s.Play();
        }
    }
}
