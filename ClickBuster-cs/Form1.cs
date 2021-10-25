using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickBuster_cs
{
    public partial class F_Menu : Form
    {
        public F_Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初級ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_Syokyu_Click(object sender, EventArgs e)
        {
            F_Main fMain = new F_Main
            {
                Height = 400,    // フォームの高さ
                Width = 400,     // フォームの幅
                EnmTim = 1000,   // 敵の動く速度
                Enms = 20,       // 敵の数
                GmTim = 10000    // 制限時間
            };

            // 難易度初期化
            fMain.FrmIni();

            fMain.Show(this);
            Hide();
        }

        /// <summary>
        /// 中級ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_Chukyu_Click(object sender, EventArgs e)
        {
            F_Main fMain = new F_Main
            {
                Height = 500,    // フォームの高さ
                Width = 700,     // フォームの幅
                EnmTim = 800,    // 敵の動く速度
                Enms = 30,       // 敵の数
                GmTim = 15000    // 制限時間
            };

            // 難易度初期化
            fMain.FrmIni();

            // thisを指定することにより、子フォームに親フォームを設定
            fMain.Show(this);
            Hide();
        }

        /// <summary>
        /// 上級ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_Jyokyu_Click(object sender, EventArgs e)
        {
            F_Main fMain = new F_Main
            {
                Height = 600,    // フォームの高さ
                Width = 800,     // フォームの幅
                EnmTim = 300,    // 敵の動く速度
                Enms = 40,       // 敵の数
                GmTim = 20000    // 制限時間
            };

            // 難易度初期化
            fMain.FrmIni();

            // thisを指定することにより、子フォームに親フォームを設定
            fMain.Show(this);
            Hide();
        }

        /// <summary>
        /// 終了ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
