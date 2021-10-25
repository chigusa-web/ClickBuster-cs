using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickBuster_cs
{
    class CEnemy
    {
        // 敵の画像
        private PictureBox _pbImgEnemy;
        // 敵が出現するオーナー
        private Control _enemyOwner;
        // ランダム変数
        private Random _rnd;
        // 敵を倒した時の得点
        private int _intTokuten;
        // 敵が動く際の幅
        private int _intMvwd;
        // 上下左右に動く
        private int _intMvud;
        // 敵のパターン
        private int _intMovePattern;

        // クリックイベント
        public event EventHandler OnClick;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="owner">敵が出現するオーナー</param>
        /// <param name="rand"></param>
        public CEnemy(Control owner, Random rand)
        {
            // 敵の画像を表示する変数を初期化
            _pbImgEnemy = new PictureBox();
            // オーナーの取得
            _enemyOwner = owner;
            // ランダム変数
            _rnd = rand;
            // 敵が動く際の幅の初期化
            _intMvwd = 10;
            // 上下左右に動く
            _intMvud = 0;

            // 敵画像がクリックされたイベント
            _pbImgEnemy.Click += new EventHandler(DoClick);
            // ランダムな場所に出現
            _RandPlace();
            // オーナーに画像を貼り付け
            _enemyOwner.Controls.Add(_pbImgEnemy);
        }

        /// <summary>
        /// 画像クリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoClick(object sender, EventArgs e)
        {
            OnClick(this, e);
        }

        /// <summary>
        /// 敵画像をランダムな場所に作成
        /// </summary>
        private void _RandPlace()
        {

            // 出現場所はオーナーの範囲内にする
            // 高さ
            var intTop = _rnd.Next(_enemyOwner.Size.Height - _pbImgEnemy.Size.Height);
            _pbImgEnemy.Top = intTop;
            // 横
            var intLeft = _rnd.Next(_enemyOwner.Size.Width - _pbImgEnemy.Size.Width);
            _pbImgEnemy.Left = intLeft;

            // 敵のパターン(画像と得点)をランダムに指定する
            _intMovePattern = _rnd.Next(1, 4);
            _pbImgEnemy.SizeMode = PictureBoxSizeMode.AutoSize;

            switch (_intMovePattern)
            {
                case 1:
                    // 画像読み込み
                    _pbImgEnemy.Image = Image.FromFile("enemy1.gif");
                    // 得点
                    _intTokuten = 500;
                    break;
                case 2:
                    // 画像読み込み
                    _pbImgEnemy.Image = Image.FromFile("enemy2.gif");
                    // 得点
                    _intTokuten = 1000;
                    break;
                case 3:
                    // 画像読み込み
                    _pbImgEnemy.Image = Image.FromFile("enemy3.gif");
                    // 得点
                    _intTokuten = 3000;
                    break;
            }

        }

        /// <summary>
        /// 動かす(オーナーの中での動き)
        /// </summary>
        public void MvEnm()
        {
            switch (_intMovePattern)
            {
                case 1:
                    //--------------------
                    // enemy1
                    // 完全ランダムな動き
                    //-------------------
                    var intMv = _rnd.Next(1, 5);
                    switch (intMv)
                    {
                        case 1:
                            // 下
                            if ((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) < _enemyOwner.Height)
                            {
                                _pbImgEnemy.Top += _intMvwd;
                            }
                            break;
                        case 2:
                            // 上
                            if ((_pbImgEnemy.Top - _intMvwd) > 0)
                            {
                                _pbImgEnemy.Top -= _intMvwd;
                            }
                            break;
                        case 3:
                            // 右
                            if ((_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvwd) < _enemyOwner.Width)
                            {
                                _pbImgEnemy.Left += _intMvwd;
                            }
                            break;
                        case 4:
                            // 左
                            if ((_pbImgEnemy.Left - _intMvwd) > 0)
                            {
                                _pbImgEnemy.Left -= _intMvwd;
                            }
                            break;
                    }
                    break;
                case 2:
                    //--------------------------
                    // enemy2
                    // 上下左右にぶつかるまで動く
                    //--------------------------
                    if (_intMvud == 0)
                    {
                        // 初回時だけは上下左右どちらに進むか決める
                        _intMvud = _rnd.Next(1, 5);
                    }

                    switch (_intMvud)
                    {
                        case 1:
                            // 下
                            if ((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) < _enemyOwner.Height)
                            {
                                _pbImgEnemy.Top += _intMvwd;
                            }
                            else
                            {
                                _intMvud = _rnd.Next(1, 5);
                            }
                            break;
                        case 2:
                            // 上
                            if ((_pbImgEnemy.Top - _intMvwd) > 0)
                            {
                                _pbImgEnemy.Top -= _intMvwd;
                            }
                            else
                            {
                                _intMvud = _rnd.Next(1, 5);
                            }
                            break;
                        case 3:
                            // 右
                            if ((_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvwd) < _enemyOwner.Width)
                            {
                                _pbImgEnemy.Left += _intMvwd;
                            }
                            else
                            {
                                _intMvud = _rnd.Next(1, 5);
                            }
                            break;
                        case 4:
                            // 左
                            if ((_pbImgEnemy.Left - _intMvwd) > 0)
                            {
                                _pbImgEnemy.Left -= _intMvwd;
                            }
                            else
                            {
                                _intMvud = _rnd.Next(1, 5);
                            }
                            break;
                    }
                    break;
                case 3:
                    //--------------------------
                    // enemy3
                    // ななめに動く
                    //--------------------------
                    if (_intMvud == 0)
                    {
                        // 初回時だけは上下左右のななめに進むか決める
                        _intMvud = _rnd.Next(1, 5);
                    }

                    switch (_intMvud)
                    {
                        case 1:
                            // 斜め右下 
                            if ((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) < _enemyOwner.Height)
                            {
                                _pbImgEnemy.Top += _intMvwd;
                            }
                            else
                            {
                                _intMvud = _rnd.Next(1, 5);
                            }

                            if (((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) < _enemyOwner.Height) &&
                                ((_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvwd) < _enemyOwner.Width))
                            {
                                _pbImgEnemy.Top += _intMvwd;
                                _pbImgEnemy.Left += _intMvwd;
                            }
                            else
                            {
                                // 次は跳ね返った位置
                                if ((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) >= _enemyOwner.Height)
                                {
                                    // 斜め右上
                                    _intMvud = 2;
                                }
                                else if ((_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvwd) >= _enemyOwner.Width)
                                {
                                    // 斜め左下
                                    _intMvud = 3;
                                }
                            }
                            break;
                        case 2:
                            // 斜め右上
                            if (((_pbImgEnemy.Top - _intMvwd) > 0) &&
                                 (_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvwd) < _enemyOwner.Width)
                            {
                                _pbImgEnemy.Top -= _intMvwd;
                                _pbImgEnemy.Left += _intMvwd;
                            }
                            else
                            {
                                // 次は跳ね返った位置
                                if ((_pbImgEnemy.Top - _intMvwd) <= 0)
                                {
                                    // 斜め右下
                                    _intMvud = 1;
                                }
                                else if ((_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvwd) >= _enemyOwner.Width)
                                {
                                    // 斜め左上
                                    _intMvud = 4;
                                }
                            }
                            break;
                        case 3:
                            // 斜め左下
                            if (((_pbImgEnemy.Left - _intMvwd) > 0) &&
                               ((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) < _enemyOwner.Height))
                            {
                                _pbImgEnemy.Top += _intMvwd;
                                _pbImgEnemy.Left -= _intMvwd;
                            }
                            else
                            {
                                // 次は跳ね返った位置
                                if ((_pbImgEnemy.Left - _intMvwd) <= 0)
                                {
                                    // 斜め右下
                                    _intMvud = 1;
                                }
                                else if ((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) >= _enemyOwner.Height)
                                {
                                    // 斜め左上
                                    _intMvud = 4;
                                }
                            }
                            break;
                        case 4:
                            // 斜め左上
                            if (((_pbImgEnemy.Left - _intMvwd) > 0) &&
                               ((_pbImgEnemy.Top - _intMvwd) > 0))
                            {
                                _pbImgEnemy.Top -= _intMvwd;
                                _pbImgEnemy.Left -= _intMvwd;
                            }
                            else
                            {
                                // 次は跳ね返った位置
                                if ((_pbImgEnemy.Left - _intMvwd) <= 0)
                                {
                                    //斜め右上
                                    _intMvud = 2;
                                }
                                else if ((_pbImgEnemy.Top - _intMvwd) <= 0)
                                {
                                    // 斜め左下
                                    _intMvud = 3;
                                }
                            }
                            break;
                    }
                    break;
            }
        }

        /// <summary>
        /// 敵が倒されたイベント
        /// </summary>
        public void EnemyDown()
        {
            // 違う場所に出現する
            _RandPlace();
        }

        /// <summary>
        /// 敵の得点のゲット
        /// </summary>
        /// <returns></returns>
        public int GetTokuten()
        {
            return _intTokuten;
        }

    }
}
