namespace YILANOYUNUERDALFİDAN
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.puan12 = new System.Windows.Forms.Label();
            this.puan = new System.Windows.Forms.Label();
            this.sure = new System.Windows.Forms.Label();
            this.timerYilanHareket = new System.Windows.Forms.Timer(this.components);
            this.timersaat = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(12, 92);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(461, 308);
            this.panel.TabIndex = 1;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Puan:";
            // 
            // puan12
            // 
            this.puan12.AutoSize = true;
            this.puan12.ForeColor = System.Drawing.Color.White;
            this.puan12.Location = new System.Drawing.Point(373, 27);
            this.puan12.Name = "puan12";
            this.puan12.Size = new System.Drawing.Size(46, 21);
            this.puan12.TabIndex = 4;
            this.puan12.Text = "Süre:";
            // 
            // puan
            // 
            this.puan.AutoSize = true;
            this.puan.ForeColor = System.Drawing.Color.White;
            this.puan.Location = new System.Drawing.Point(88, 27);
            this.puan.Name = "puan";
            this.puan.Size = new System.Drawing.Size(19, 21);
            this.puan.TabIndex = 5;
            this.puan.Text = "0";
            // 
            // sure
            // 
            this.sure.AutoSize = true;
            this.sure.ForeColor = System.Drawing.Color.White;
            this.sure.Location = new System.Drawing.Point(425, 27);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(19, 21);
            this.sure.TabIndex = 4;
            this.sure.Text = "0";
            // 
            // timerYilanHareket
            // 
            this.timerYilanHareket.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timersaat
            // 
            this.timersaat.Interval = 1000;
            this.timersaat.Tick += new System.EventHandler(this.timersaat_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(485, 412);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.puan);
            this.Controls.Add(this.puan12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "YILAN OYUNU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label sure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label puan12;
        private System.Windows.Forms.Label puan;
        private System.Windows.Forms.Timer timerYilanHareket;
        private System.Windows.Forms.Timer timersaat;
    }
}

