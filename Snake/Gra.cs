using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Gra : Form
    {
        int cols = 50, rows = 25, score = 0, dx = 0, dy = 0, front = 0, back = 0;
        // int dxprev=0,dyprev=0;
        Piece[] snake = new Piece[1250];
        List<int> avaliable = new List<int>();
        bool[,] visit;
        Random rand = new Random();
        Timer timer = new Timer();

        public Gra()
        {
            InitializeComponent();
            initial();
            LaunchTimer();
        }
        private void LaunchTimer()
        {
            timer.Interval = 100;
            timer.Tick += move;
            timer.Start();
        }

        private void move(object sender, EventArgs e)
        {
            int x = snake[front].Location.X, y = snake[front].Location.Y;

            if (dx == 0 && dy == 0)
            {
                return;
            }

            if (game_over(x + dx, y + dy))
            {
                timer.Stop();
                // MessageBox.Show("Game Over");
                 odczyt uzytkownik = new odczyt(label1.Text, Int32.Parse(label3.Text));
                uzytkownik.zamianarekordku(score);
                Gameover form11 = new Gameover();
                form11.label2.Text = uzytkownik.getlogin();
                form11.label3.Text = uzytkownik.getrekord().ToString();
                form11.label6.Text = "Snake hit the wall";
                Random rnd = new Random();
                int losowanie = rnd.Next(1, 5);
                if (losowanie == 1)
                {
                    form11.label8.Text = "Teletubisie i spółka";

                }
                else if (losowanie == 2)
                {
                    form11.label8.Text = "Piwo to przyszlosc";
                }
                else if (losowanie == 3)
                {
                    form11.label8.Text = "Fundacja: pomoż studentom przetrwać sesje";
                }
                else if (losowanie == 4)
                {
                    form11.label8.Text = "RKS robotniczy klub sportowy ";
                }
                form11.Show();
                this.Hide();
                return;

            }

            if (collisionFood(x + dx, y + dy))
            {
                score += 1;
                lblScore.Text = "Score: " + score.ToString();
                if (hits((y + dy) / 20, (x + dx) / 20)) return;
                Piece head = new Piece(x + dx, y + dy);
                front = (front - 1 + 1250) % 1250;
                snake[front] = head;
                visit[head.Location.Y / 20, head.Location.X / 20] = true;
                Controls.Add(head);
                randomFood();
            }

            else
            {
                if (hits((y + dy) / 20, (x + dx) / 20)) return;
                visit[snake[back].Location.Y / 20, snake[back].Location.X / 20] = false;
                front = (front - 1 + 1250) % 1250;
                snake[front] = snake[back];
                snake[front].Location = new Point(x + dx, y + dy);
                back = (back - 1 + 1250) % 1250;
                visit[(y + dy) / 20, (x + dx) / 20] = true;
            }
        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            dx = dy = 0;
            switch (e.KeyCode)
            {
                case Keys.Right:
                    dx = 20;
                    break;
                case Keys.Left:
                    dx = -20;
                    break;
                case Keys.Up:
                    dy = -20;
                    break;
                case Keys.Down:
                    dy = 20;
                    break;
            }
        }

        private void randomFood()
        {
            avaliable.Clear();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (!visit[i, j])
                    {
                        avaliable.Add(i * cols + j);
                    }
                }
            }
            int idx = rand.Next(avaliable.Count) % avaliable.Count;
            lblFood.Left = (avaliable[idx] * 20) % Width;
            lblFood.Top = (avaliable[idx] * 20) / Width * 20;

        }

        private bool hits(int x, int y)
        {
            if (visit[x, y])
            {
                timer.Stop();
                // MessageBox.Show("Snake hit his  body");
                odczyt uzytkownik = new odczyt(label1.Text, Int32.Parse(label3.Text));
                uzytkownik.zamianarekordku(score);
                Gameover form11 = new Gameover();
                form11.label2.Text = uzytkownik.getlogin();
                form11.label3.Text = uzytkownik.getrekord().ToString();
                form11.label6.Text = "Snake hit his  body";
                Random rnd = new Random();
                int losowanie = rnd.Next(1, 5);
                if(losowanie ==1)
                {
                    form11.label8.Text = "Teletubisie i spółka";

                }
                else if (losowanie == 2)
                {
                    form11.label8.Text = "Piwo to przyszlosc";
                }
                else if (losowanie == 3)
                {
                    form11.label8.Text = "Fundacja: pomoż studentom przetrwać sesje";
                }
                else if (losowanie == 4)
                {
                    form11.label8.Text = "RKS robotniczy klub sportowy ";
                }


                form11.Show();
                this.Hide();
                return true;
            }
            return false;
        }

        private bool collisionFood(int x, int y)
        {
            return x == lblFood.Location.X && y == lblFood.Location.Y;
        }

        private bool game_over(int x, int y)
        {
            return x < 0 || y < 0 || x > 980 || y > 480;
        }

        void Form1_Load(object sender, EventArgs e)
        {

        }

        private void initial()
        {
            visit = new bool[rows, cols];
            Piece head = new Piece((rand.Next() % cols) * 20, (rand.Next() % rows) * 20);
            lblFood.Location = new Point((rand.Next() % cols) * 20, (rand.Next() % rows) * 20);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    visit[i, j] = false;
                    avaliable.Add(i * cols + j);
                }
            }
            visit[head.Location.Y / 20, head.Location.X / 20] = true;
            avaliable.Remove(head.Location.Y / 20 * cols + head.Location.X / 20);
            Controls.Add(head);
            snake[front] = head;
        }
    }
}

