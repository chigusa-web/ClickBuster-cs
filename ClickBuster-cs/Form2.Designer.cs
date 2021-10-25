
namespace ClickBuster_cs
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
            this.B_Start = new System.Windows.Forms.Button();
            this.L_Jikan = new System.Windows.Forms.Label();
            this.L_Tokuten = new System.Windows.Forms.Label();
            this.L_Sum = new System.Windows.Forms.Label();
            this.PG_Jikan = new System.Windows.Forms.ProgressBar();
            this.P_Enemy = new System.Windows.Forms.Panel();
            this.T_Enemy = new System.Windows.Forms.Timer(this.components);
            this.T_Jikan = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // B_Start
            // 
            this.B_Start.Location = new System.Drawing.Point(20, 18);
            this.B_Start.Name = "B_Start";
            this.B_Start.Size = new System.Drawing.Size(133, 74);
            this.B_Start.TabIndex = 0;
            this.B_Start.Text = "スタート";
            this.B_Start.UseVisualStyleBackColor = true;
            this.B_Start.Click += new System.EventHandler(this.B_Start_Click);
            // 
            // L_Jikan
            // 
            this.L_Jikan.AutoSize = true;
            this.L_Jikan.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.L_Jikan.Location = new System.Drawing.Point(163, 18);
            this.L_Jikan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.L_Jikan.Name = "L_Jikan";
            this.L_Jikan.Size = new System.Drawing.Size(97, 24);
            this.L_Jikan.TabIndex = 1;
            this.L_Jikan.Text = "残り時間";
            // 
            // L_Tokuten
            // 
            this.L_Tokuten.AutoSize = true;
            this.L_Tokuten.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.L_Tokuten.Location = new System.Drawing.Point(415, 18);
            this.L_Tokuten.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.L_Tokuten.Name = "L_Tokuten";
            this.L_Tokuten.Size = new System.Drawing.Size(58, 24);
            this.L_Tokuten.TabIndex = 2;
            this.L_Tokuten.Text = "得点";
            // 
            // L_Sum
            // 
            this.L_Sum.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.L_Sum.Location = new System.Drawing.Point(415, 68);
            this.L_Sum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.L_Sum.Name = "L_Sum";
            this.L_Sum.Size = new System.Drawing.Size(205, 24);
            this.L_Sum.TabIndex = 3;
            this.L_Sum.Text = "0";
            this.L_Sum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PG_Jikan
            // 
            this.PG_Jikan.Location = new System.Drawing.Point(168, 52);
            this.PG_Jikan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PG_Jikan.Maximum = 10;
            this.PG_Jikan.Name = "PG_Jikan";
            this.PG_Jikan.Size = new System.Drawing.Size(237, 39);
            this.PG_Jikan.TabIndex = 4;
            this.PG_Jikan.Value = 10;
            // 
            // P_Enemy
            // 
            this.P_Enemy.BackColor = System.Drawing.Color.White;
            this.P_Enemy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P_Enemy.Location = new System.Drawing.Point(20, 100);
            this.P_Enemy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.P_Enemy.Name = "P_Enemy";
            this.P_Enemy.Size = new System.Drawing.Size(597, 601);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 722);
            this.Controls.Add(this.P_Enemy);
            this.Controls.Add(this.PG_Jikan);
            this.Controls.Add(this.L_Sum);
            this.Controls.Add(this.L_Tokuten);
            this.Controls.Add(this.L_Jikan);
            this.Controls.Add(this.B_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClickBuster (メイン画面)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Main_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Start;
        private System.Windows.Forms.Label L_Jikan;
        private System.Windows.Forms.Label L_Tokuten;
        private System.Windows.Forms.Label L_Sum;
        private System.Windows.Forms.ProgressBar PG_Jikan;
        private System.Windows.Forms.Panel P_Enemy;
        private System.Windows.Forms.Timer T_Enemy;
        private System.Windows.Forms.Timer T_Jikan;
    }
}