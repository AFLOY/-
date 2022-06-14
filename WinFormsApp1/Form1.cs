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
        int a = 0;//ルーレットの回転角度
        Point ptx = new Point();//プレイヤーの座標
        int ti = 100;//タイマーのインタバルを変更
        int roulette_score1;//プレイヤーのルーレットの値
        int clock_fin = 0;//ルーレットの回転を止める場所の判定用
        int basetime = 0;//ルーレットが回転してからの経過時間
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
            if(basetime <= 900)//加速
            {
                ti = ti - 5;
            }
            if(basetime >= 4000 && basetime <= 8000)//減速
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

        void random_roulette()//ルーレットの値出し && プレイヤーの場所出し
        {
            int seed = Environment.TickCount;
            Random r1 = new Random(seed);
            roulette_score1 = r1.Next(1, 10);
            player_position = roulette_score1;
        }

        void roulette_rotate()//ルーレット画像の回転
        {
            if(a <= -360)
            {
                a = a + 360;
            }
            a = a - 5;
            Bitmap tesy = global::WinFormsApp1.Properties.Resources.円1;
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

        void mark_move_player()//プレイヤー画像・背景の位置を指定
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

        void draw_picture()//プレイヤー画像・背景の描写
        {
            Graphics g = pictureBox1.CreateGraphics();

            Bitmap back = global::WinFormsApp1.Properties.Resources.背景;
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