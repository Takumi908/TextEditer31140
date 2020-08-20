﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditer31140
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //アプリ終了
            Application.Exit();
        }

        private void SaveNameAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(sfdFileSave.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfdFileSave.FileName,false,Encoding.GetEncoding("utf-8")))
                {
                    sw.WriteLine(rtTextArea.Text);
                }
            }
        }

        private void OopenOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ダイアログ表示
            if(ofdFileOpeen.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofdFileOpeen.FileName,Encoding.GetEncoding("utf-8"),false))
                {
                    rtTextArea.Text = sr.ReadToEnd();//読み込んだものをすべて入れる
                }
            }
        }
    }
}
