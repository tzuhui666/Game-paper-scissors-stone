using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1102056FinalProject
{
    public partial class Form1 : Form
    {
        int com=0;
        int time = 0;
        int win = 0;
        int loss = 0;
        int tie = 0;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            text_time.ReadOnly = true;
            picbox_com.Image = imageList1.Images[0];
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            com=random.Next(1,4);
            if (com == 1)
            {
                picbox_com.Image = imageList1.Images[com];
                MessageBox.Show("我們平手");
                tie++;
            }
            else if (com == 2)
            {
                picbox_com.Image = imageList1.Images[com];
                MessageBox.Show("你輸了");
                loss++;
            }
            else if (com == 3)
            {
                picbox_com.Image = imageList1.Images[com];
                MessageBox.Show("你贏了");
                win++;
            }
            time++;
            text_time.Text = "紀錄 : 玩了" + time + "次" + "  " + "贏了" + win + "次" + "  " + "輸了" + loss + "次" + "  " + "平手" + tie + "次";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            com = random.Next(1, 4);
            if (com == 1)
            {
                picbox_com.Image = imageList1.Images[com];
                MessageBox.Show("你贏了");
                win++;
            }
            else if (com == 2)
            {
                picbox_com.Image = imageList1.Images[com];
                MessageBox.Show("我們平手");
                tie++;
            }
            else if (com == 3)
            {
                picbox_com.Image = imageList1.Images[com];
                MessageBox.Show("你輸了");
                loss++;
            }
            time++;
            text_time.Text = "紀錄 : 玩了" + time + "次" + "  " + "贏了" + win + "次" + "  " + "輸了" + loss + "次" + "  " + "平手" + tie + "次";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            com = random.Next(1, 4);
            if (com == 1)
            {
                picbox_com.Image = imageList1.Images[com];
                MessageBox.Show("你輸了");
                loss++;
            }
            else if (com == 2)
            {
                picbox_com.Image = imageList1.Images[com];
                MessageBox.Show("你贏了");
                win++;
            }
            else if (com == 3)
            {
                picbox_com.Image = imageList1.Images[com];
                MessageBox.Show("我們平手");
                tie++;
            }
            time++;
            text_time.Text = "紀錄 : 玩了" + time + "次" + "  " + "贏了" + win + "次" + "  " + "輸了" + loss + "次" + "  " + "平手" + tie + "次";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
