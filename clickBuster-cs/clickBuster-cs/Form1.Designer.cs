namespace clickBuster_cs
{
    partial class F_Menu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.b_Syokyu = new System.Windows.Forms.Button();
            this.b_Chukyu = new System.Windows.Forms.Button();
            this.B_Jyokyu = new System.Windows.Forms.Button();
            this.b_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_Syokyu
            // 
            this.b_Syokyu.Location = new System.Drawing.Point(12, 12);
            this.b_Syokyu.Name = "b_Syokyu";
            this.b_Syokyu.Size = new System.Drawing.Size(260, 74);
            this.b_Syokyu.TabIndex = 0;
            this.b_Syokyu.Text = "初級";
            this.b_Syokyu.UseVisualStyleBackColor = true;
            this.b_Syokyu.Click += new System.EventHandler(this.b_Syokyu_Click);
            // 
            // b_Chukyu
            // 
            this.b_Chukyu.Location = new System.Drawing.Point(12, 92);
            this.b_Chukyu.Name = "b_Chukyu";
            this.b_Chukyu.Size = new System.Drawing.Size(260, 74);
            this.b_Chukyu.TabIndex = 1;
            this.b_Chukyu.Text = "中級";
            this.b_Chukyu.UseVisualStyleBackColor = true;
            this.b_Chukyu.Click += new System.EventHandler(this.b_Chukyu_Click);
            // 
            // B_Jyokyu
            // 
            this.B_Jyokyu.Location = new System.Drawing.Point(12, 172);
            this.B_Jyokyu.Name = "B_Jyokyu";
            this.B_Jyokyu.Size = new System.Drawing.Size(260, 74);
            this.B_Jyokyu.TabIndex = 2;
            this.B_Jyokyu.Text = "上級";
            this.B_Jyokyu.UseVisualStyleBackColor = true;
            this.B_Jyokyu.Click += new System.EventHandler(this.B_Jyokyu_Click);
            // 
            // b_Close
            // 
            this.b_Close.Location = new System.Drawing.Point(12, 275);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(260, 74);
            this.b_Close.TabIndex = 3;
            this.b_Close.Text = "終了";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.B_Jyokyu);
            this.Controls.Add(this.b_Chukyu);
            this.Controls.Add(this.b_Syokyu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClickBuster(メニュー画面)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_Syokyu;
        private System.Windows.Forms.Button b_Chukyu;
        private System.Windows.Forms.Button B_Jyokyu;
        private System.Windows.Forms.Button b_Close;
    }
}

