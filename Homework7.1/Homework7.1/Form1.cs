using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Homework7;
//1. а) Добавить в программу «Удвоитель» подсчет количества отданных команд.
//б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
//Игрок должен постараться получить это число за минимальное количество ходов.

namespace Homework7
{
    public partial class fMain : Form
    {
        Udvoitel udvoitel;
        int pressButtonCount=0;
        bool flag;

        public fMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            udvoitel = new Udvoitel(2, 10);
            UpdateInfo();
            pressButtonCount = 0;
        }

        private void UpdateInfo()
        {

            lblFinish.Text = udvoitel.Finish.ToString();
            tbCurrent.Text = udvoitel.Current.ToString();
            lblUserPressCount.Text = pressButtonCount.ToString();
            Compare();
            if ((lblFinish.Text == tbCurrent.Text)&&(flag))
            {
                MessageBox.Show("You win!");
            }

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (udvoitel == null)
            {
                MessageBox.Show("Start game!");
                udvoitel = new Udvoitel(2, 10);
                return;
            }
            udvoitel.Plus();
            UpdateInfo();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (udvoitel == null)
            {
                MessageBox.Show("Start game!");
                udvoitel = new Udvoitel(2, 10);
                return;
            }
            udvoitel.Multi();
            UpdateInfo();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            udvoitel = new Udvoitel(2, 10);
            udvoitel.Reset();
            UpdateInfo();
        }
        private void Any_Click(object sender, EventArgs e)
        {
            pressButtonCount++;
            UpdateInfo();

        }
        private void Compare()
        {
            double number=Convert.ToDouble(udvoitel.Finish);
            int iter = 0;
            while (number >= 1)
            {
                if (number % 2 != 0)
                {
                    number = number-1; iter++;
                }
                else number = number / 2; iter++;
            }
            flag = (iter >= pressButtonCount) ? true : false;
        }
    }
}
