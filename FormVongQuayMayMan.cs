using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHTT
{
    public partial class FormVongQuayMayMan : Form
    {
        public SendMessage send;
        static string tenqua;
        static string livePath = Environment.CurrentDirectory;
        static Image[] images = new Image[8];
        static int i = 0;
        static bool isWheelSpinning = false;
        static Thread spinWheel = new Thread(SpinTheWheel);
        static PictureBox wh = new PictureBox(); //did this to be able to close the spinWheel thread anywher in code
        public FormVongQuayMayMan()
        {
            InitializeComponent();
            
            wh = Wheel_PictureBox;
        }
        public FormVongQuayMayMan(SendMessage sender)
        {
            InitializeComponent();

            wh = Wheel_PictureBox;
            this.send = sender;
        }
        static void ChangeWheel_Image()
        {
            if (i + 1 >= images.Length)
                i = 0;
            else
                i++;

            images[i] = Image.FromFile(livePath + "\\Resources\\Slot " + (i + 1) + " active.png");
            wh.Invoke(new Action(() => wh.BackgroundImage = images[i]));
        }

        static void congrats(int i)
        {
            if (i + 1 == 1 || i + 1 == 5)
            { 
                MessageBox.Show("Thật tiếc! Chúc bạn may mắn lần sau.");
                tenqua = "Không";
            }
            if (i + 1 == 2 || i + 1 == 6)
            {
                MessageBox.Show("Chúc mừng! Bạn đã trúng 1 Nước hoa tinh dầu.");
                tenqua = "Nước hoa tinh dầu";
            }
            if (i + 1 == 3 || i + 1 == 7)
            {
                MessageBox.Show("Chúc mừng! Bạn đã trúng 1 Máy sấy tóc.");
                tenqua = "Máy sấy tóc";
            }
            if (i + 1 == 4 || i + 1 == 8) 
            {
                MessageBox.Show("Chúc mừng! Bạn đã trúng 1 Hộp khẩu trang.");
                tenqua = "Hộp khẩu trang";
            }
            
        }
        static void SpinTheWheel()
        {
            Random rand = new Random();
            int cycle = 1;

            for (int y = 0; y < 3; y++)
            {
                //Fast spin speed
                int fastSpin = rand.Next((55 - ((cycle - 1) * 20)), (65 - ((cycle - 1) * 15)));
                for (int x = 0; x < fastSpin; x++)
                {
                    ChangeWheel_Image();
                    Thread.Sleep(40 * cycle);
                }
                cycle++;
            }

            isWheelSpinning = false;
            congrats(i);
            spinWheel.Abort();
        }

        
        private void Spin_Button_Click(object sender, EventArgs e)
        {
            if (!isWheelSpinning)
            {
                Thread spinWheel = new Thread(SpinTheWheel);
                isWheelSpinning = true;
                spinWheel.Start();
            }
        }
        private void FormVongQuayMayMan_Load(object sender, EventArgs e)
        {

        }

        private void iconbtnExit_Click(object sender, EventArgs e)
        {     
           this.send(tenqua);
           this.Close();
        }
    }
}
