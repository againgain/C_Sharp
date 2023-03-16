﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;   //20230206_18:46波線

namespace clickBuster_cs
{
    public partial class F_Main : Form
    {
        //敵の数
        public int Enms;
        //敵の動くスピード(秒数)
        public int EnmTim;
        //残り時間
        public int GmTim;

        public void FrmIni()
        {
            //フォームのサイズでコントロールを配置する
            P_Enemy.Height = Height - P_Enemy.Top - 45;
            P_Enemy.Width = Width - 40;

            //合計得点
            L_Sum.Text = "0";
            //敵の動くスピード
            T_Enemy.Interval = EnmTim;
            //残り時間の初期化
            PG_jikan.Maximum = GmTim/ 1000;
            PG_jikan.Value = PG_jikan.Maximum;
        }


        //ランダム変数
        private Random _rnd = new Random();

        //複数の敵を格納する変数
        private ArrayList _enemies = new ArrayList();


        public F_Main()
        {
            InitializeComponent();
        }

        private void F_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            //メニュー画面の表示
            Owner.Show();
        }


        /// <summary>
        /// スタートボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_Start_Click(object sender, EventArgs e)
        {
            //スタートボタンを使えなくする
            b_Start.Enabled = false;

            //敵を生成する
            for(int i = 0; i <= 9; i++)
            {
                //配列に敵クラスを生成します。その際にオーナーのパネルとランダム変数を渡します。
                _enemies.Add(new CEnemy(P_Enemy, _rnd));
                //敵のクリックイベント(倒すイベント)
                ((CEnemy)_enemies[i]).OnClick += new EventHandler(EnmOnClick);
                //ループの中でDoEventsを呼んでおく
                Application.DoEvents();
            }

            //タイマーのスタート
            T_Enemy.Enabled = true;
            T_Jikan.Enabled = true;
        }

        /// <summary>
        /// 敵を動かす
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void T_Enemy_Tick(object sender, EventArgs e)
        {
            //敵の数だけループする
            for(int i = 0; i <= _enemies.Count-1; i++)
            {
                //敵の移動イベントを呼ぶ
                ((CEnemy)_enemies[i]).MvEnm();
                //ループの中でDoEventsを呼んでおく
                Application.DoEvents();
            }
        }

        /// <summary>
        /// 残り時間を計測
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void T_Jikan_Tick(object sender, EventArgs e)
        {
            if((PG_jikan.Minimum) <= (PG_jikan.Value -1)) 
            {
                //プログレスバーを１つ下げる
                PG_jikan.Value--;
            }
            else
            {
                //終わり
                PG_jikan.Value = PG_jikan.Minimum;
                //タイマーを止める
                T_Enemy.Enabled = false;
                T_Jikan.Enabled = false;
                //メッセージを表示
                MessageBox.Show("終了です\nあなたの得点は" + L_Sum.Text + "です");
                //メイン画面を閉じる
                Close();
            }
        }

        private void EnmOnClick(object sender, EventArgs e)
        {
            //得点の加算（それぞれの敵の得点を取得する）
            L_Sum.Text = (Int32.Parse(L_Sum.Text) + ((CEnemy)sender).GetTokukten()).ToString();
            //敵を倒したイベント（再度敵を出現させる）
            ((CEnemy)sender).EnemyDown();
        }

    }
}
