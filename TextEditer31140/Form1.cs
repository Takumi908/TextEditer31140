using System;
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
        private string fileName = "";

        public Form1()
        {
            InitializeComponent();
        }

        //終了
        private void ExitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //アプリ終了
            Application.Exit();
        }

        //名前を付けて保存
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

        //開く
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

        //上書き保存
        private void SaveAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdFileSave.ShowDialog() == DialogResult.OK)
            {
                FileSave(sfdFileSave.FileName);
            }
        }

        //ファイル名を指定しデータを保存
        private void FileSave (string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.GetEncoding("utf-8")))
            {
                sw.WriteLine(rtTextArea.Text);
                this.fileName = fileName;
                this.Text = fileName;
            }
        }

        //元に戻す
        private void returnUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtTextArea.CanUndo == true)
            {
                rtTextArea.Undo();
            }
        }

        //やり直し
        private void soToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(rtTextArea.CanRedo == true)
            {
                rtTextArea.Redo();
            }
        }

        //切り取り
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtTextArea.Cut();
        }


        //コピー
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Clipboard.SetDataObject(rtTextArea.Text);  
        }

        //貼り付け
        private void PeestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDataObject data = Clipboard.GetDataObject();
            if (data.GetDataPresent(DataFormats.Text) == true)
            {
                //クリップボードにテキストが入っている
                rtTextArea.Paste();
            }
        }

        //削除
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtTextArea.Cut();
            Clipboard.Clear();
        }

        //マスク処理
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorToolStripMenuItem.Enabled = false;
            fontToolStripMenuItem.Enabled = false;
        }
    }
}
