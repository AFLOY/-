namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point pt1 = new Point(30, 30);
        Point pt2 = new Point(90, 30);
        Point pt3 = new Point(150, 30);
        Point pt4 = new Point(210, 30);
        Point pt5 = new Point(270, 30);
        Point pt6 = new Point(330, 30);
        Point pt7 = new Point(390, 30);
        Point pt8 = new Point(450, 30);
        Point pt9 = new Point(510, 30);
        Point pt10 = new Point(570, 30);
        int player_position;
        int a = 0;//���[���b�g�̉�]�p�x
        Point ptx = new Point();//�v���C���[�̍��W
        int ti = 100;//�^�C�}�[�̃C���^�o����ύX
        int roulette_score1;//�v���C���[�̃��[���b�g�̒l
        int clock_fin = 0;//���[���b�g�̉�]���~�߂�ꏊ�̔���p
        int basetime = 0;//���[���b�g����]���Ă���̌o�ߎ���
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timer_spendcheck = new System.Windows.Forms.Timer();
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(clock);
            timer.Interval = ti;
            timer_spendcheck.Tick += new EventHandler(standard_time);
            timer_spendcheck.Interval = 100;
        }

        private void standard_time(object sender, EventArgs e)
        {
            basetime = basetime + 100;
        }
        
        private void clock(object sender, EventArgs e)
        {
            if(basetime <= 900)//����
            {
                ti = ti - 5;
            }
            if(basetime >= 4000 && basetime <= 8000)//����
            {
                ti = ti + 1;
            }
            if(basetime > 8000)
            {
                clock_fin = 1;
            }
            textBox2.Text = Convert.ToString(ti);
            timer.Interval = ti;
            roulette_rotate();
            if (clock_fin == 1)
            {
                if (roulette_score1 == 1 && 18 >= a && a >= -18)
                {
                    timer.Enabled = false;
                    timer_spendcheck.Enabled = false;
                    basetime = 0;
                    ti = 100;
                    clock_fin = 0;
                    draw_picture();
                }
                if (roulette_score1 == 2 && -19 >= a && a >= -53)
                {
                    timer.Enabled = false;
                    timer_spendcheck.Enabled = false;
                    basetime = 0;
                    ti = 100;
                    clock_fin = 0;
                    draw_picture();
                }
                if (roulette_score1 == 3 && -54 >= a && a >= -88)
                {
                    timer.Enabled = false;
                    timer_spendcheck.Enabled = false;
                    basetime = 0;
                    ti = 100;
                    clock_fin = 0;
                    draw_picture();
                }
                if (roulette_score1 == 4 && -18 >= a && a >= -18)
                {
                    timer.Enabled = false;
                    timer_spendcheck.Enabled = false;
                    basetime = 0;
                    ti = 100;
                    clock_fin = 0;
                    draw_picture();
                }
                if (roulette_score1 == 5 && -18 >= a && a >= -18)
                {
                    timer.Enabled = false;
                    timer_spendcheck.Enabled = false;
                    basetime = 0;
                    ti = 100;
                    clock_fin = 0;
                    draw_picture();
                }
                if (roulette_score1 == 6 && -18 >= a && a >= -18)
                {
                    timer.Enabled = false;
                    timer_spendcheck.Enabled = false;
                    basetime = 0;
                    ti = 100;
                    clock_fin = 0;
                    draw_picture();
                }
                if (roulette_score1 == 7 && -18 >= a && a >= -18)
                {
                    timer.Enabled = false;
                    timer_spendcheck.Enabled = false;
                    basetime = 0;
                    ti = 100;
                    clock_fin = 0;
                    draw_picture();
                }
                if (roulette_score1 == 8 && -18 >= a && a >= -18)
                {
                    timer.Enabled = false;
                    timer_spendcheck.Enabled = false;
                    basetime = 0;
                    ti = 100;
                    clock_fin = 0;
                    draw_picture();
                }
                if (roulette_score1 == 9 && -18 >= a && a >= -18)
                {
                    timer.Enabled = false;
                    timer_spendcheck.Enabled = false;
                    basetime = 0;
                    ti = 100;
                    clock_fin = 0;
                    draw_picture();
                }
                if (roulette_score1 == 10 && -18 >= a && a >= -18)
                {
                    timer.Enabled = false;
                    timer_spendcheck.Enabled = false;
                    basetime = 0;
                    ti = 100;
                    clock_fin = 0;
                    draw_picture();
                }
            }
        }

        void random_roulette()//���[���b�g�̒l�o�� && �v���C���[�̏ꏊ�o��
        {
            int seed = Environment.TickCount;
            Random r1 = new Random(seed);
            roulette_score1 = r1.Next(1, 10);
            player_position = roulette_score1;
        }

        void roulette_rotate()//���[���b�g�摜�̉�]
        {
            if(a <= -360)
            {
                a = a + 360;
            }
            a = a - 5;
            Bitmap tesy = global::WinFormsApp1.Properties.Resources.�~1;
            textBox1.Text = Convert.ToString(a);
            double xs = Math.Sin(a * (Math.PI / 180));
            double yc = Math.Cos(a * (Math.PI / 180));
            int xsc = Convert.ToInt32(300 * xs);
            int ycc = Convert.ToInt32(300 * yc);
            Graphics ga = pictureBox2.CreateGraphics();
            ga.RotateTransform(a, System.Drawing.Drawing2D.MatrixOrder.Append);
            ga.TranslateTransform(60, 40, System.Drawing.Drawing2D.MatrixOrder.Append);
            ga.DrawImage(tesy, xsc - 312, ycc - 312);
        }

        void mark_move_player()//�v���C���[�摜�E�w�i�̈ʒu���w��
        {
            while (true)
            {
                if (player_position == 1)
                {
                    ptx = pt1;
                    break;
                }
                if (player_position == 2)
                {
                    ptx = pt2;
                    break;
                }
                if (player_position == 3)
                {
                    ptx = pt3;
                    break;
                }
                if (player_position == 4)
                {
                    ptx = pt4;
                    break;
                }
                if (player_position == 5)
                {
                    ptx = pt5;
                    break;
                }
                if (player_position == 6)
                {
                    ptx = pt6;
                    break;
                }
                if (player_position == 7)
                {
                    ptx = pt7;
                    break;
                }
                if (player_position == 8)
                {
                    ptx = pt8;
                    break;
                }
                if (player_position == 9)
                {
                    ptx = pt9;
                    break;
                }
                if (player_position == 10)
                {
                    ptx = pt10;
                    break;
                }
            }
        }

        void draw_picture()//�v���C���[�摜�E�w�i�̕`��
        {
            Graphics g = pictureBox1.CreateGraphics();

            Bitmap back = global::WinFormsApp1.Properties.Resources.�w�i;
            Bitmap bit1 = global::WinFormsApp1.Properties.Resources.player;

            g.DrawImage(back, -ptx.X + pictureBox1.Width / 2, -ptx.Y + pictureBox1.Height / 2);
            g.DrawImage(bit1, pictureBox1.Width / 2, pictureBox1.Height / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer.Enabled = true;
            timer_spendcheck.Enabled = true;
            random_roulette();
            mark_move_player();
        }
    }
}