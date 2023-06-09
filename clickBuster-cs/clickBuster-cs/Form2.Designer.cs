﻿namespace clickBuster_cs
{
    partial class F_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.b_Start = new System.Windows.Forms.Button();
            this.L_Jikan = new System.Windows.Forms.Label();
            this.L_Tokuten = new System.Windows.Forms.Label();
            this.L_Sum = new System.Windows.Forms.Label();
            this.PG_jikan = new System.Windows.Forms.ProgressBar();
            this.P_Enemy = new System.Windows.Forms.Panel();
            this.T_Enemy = new System.Windows.Forms.Timer(this.components);
            this.T_Jikan = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // b_Start
            // 
            this.b_Start.Location = new System.Drawing.Point(12, 12);
            this.b_Start.Name = "b_Start";
            this.b_Start.Size = new System.Drawing.Size(80, 49);
            this.b_Start.TabIndex = 0;
            this.b_Start.Text = "スタート";
            this.b_Start.UseVisualStyleBackColor = true;
            this.b_Start.Click += new System.EventHandler(this.b_Start_Click);
            // 
            // L_Jikan
            // 
            this.L_Jikan.AutoSize = true;
            this.L_Jikan.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.L_Jikan.Location = new System.Drawing.Point(98, 12);
            this.L_Jikan.Name = "L_Jikan";
            this.L_Jikan.Size = new System.Drawing.Size(65, 16);
            this.L_Jikan.TabIndex = 1;
            this.L_Jikan.Text = "残り時間";
            // 
            // L_Tokuten
            // 
            this.L_Tokuten.AutoSize = true;
            this.L_Tokuten.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.L_Tokuten.Location = new System.Drawing.Point(249, 12);
            this.L_Tokuten.Name = "L_Tokuten";
            this.L_Tokuten.Size = new System.Drawing.Size(39, 16);
            this.L_Tokuten.TabIndex = 2;
            this.L_Tokuten.Text = "得点";
            // 
            // L_Sum
            // 
            this.L_Sum.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.L_Sum.Location = new System.Drawing.Point(249, 45);
            this.L_Sum.Name = "L_Sum";
            this.L_Sum.Size = new System.Drawing.Size(123, 16);
            this.L_Sum.TabIndex = 3;
            this.L_Sum.Text = "0";
            this.L_Sum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PG_jikan
            // 
            this.PG_jikan.Location = new System.Drawing.Point(101, 35);
            this.PG_jikan.Maximum = 10;
            this.PG_jikan.Name = "PG_jikan";
            this.PG_jikan.Size = new System.Drawing.Size(142, 26);
            this.PG_jikan.TabIndex = 4;
            this.PG_jikan.Value = 10;
            // 
            // P_Enemy
            // 
            this.P_Enemy.BackColor = System.Drawing.Color.White;
            this.P_Enemy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P_Enemy.Location = new System.Drawing.Point(12, 67);
            this.P_Enemy.Name = "P_Enemy";
            this.P_Enemy.Size = new System.Drawing.Size(360, 402);
            this.P_Enemy.TabIndex = 5;
            // 
            // T_Enemy
            // 
            this.T_Enemy.Interval = 1000;
            this.T_Enemy.Tick += new System.EventHandler(this.T_Enemy_Tick);
            // 
            // T_Jikan
            // 
            this.T_Jikan.Interval = 1000;
            this.T_Jikan.Tick += new System.EventHandler(this.T_Jikan_Tick);
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 481);
            this.Controls.Add(this.P_Enemy);
            this.Controls.Add(this.PG_jikan);
            this.Controls.Add(this.L_Sum);
            this.Controls.Add(this.L_Tokuten);
            this.Controls.Add(this.L_Jikan);
            this.Controls.Add(this.b_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClickBuster(メイン画面)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Main_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Start;
        private System.Windows.Forms.Label L_Jikan;
        private System.Windows.Forms.Label L_Tokuten;
        private System.Windows.Forms.Label L_Sum;
        private System.Windows.Forms.ProgressBar PG_jikan;
        private System.Windows.Forms.Panel P_Enemy;
        private System.Windows.Forms.Timer T_Enemy;
        private System.Windows.Forms.Timer T_Jikan;
    }
}