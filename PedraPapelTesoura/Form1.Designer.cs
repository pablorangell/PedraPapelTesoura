namespace PedraPapelTesoura
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtPapel = new System.Windows.Forms.Button();
            this.BtTesoura = new System.Windows.Forms.Button();
            this.BtPedra = new System.Windows.Forms.Button();
            this.PicJogador = new System.Windows.Forms.PictureBox();
            this.PicCpu = new System.Windows.Forms.PictureBox();
            this.LbDescricaoJogador = new System.Windows.Forms.Label();
            this.LbDescricaoCpu = new System.Windows.Forms.Label();
            this.LbPtJogador = new System.Windows.Forms.Label();
            this.LbPtCpu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCpu)).BeginInit();
            this.SuspendLayout();
            // 
            // BtPapel
            // 
            this.BtPapel.BackColor = System.Drawing.Color.White;
            this.BtPapel.BackgroundImage = global::PedraPapelTesoura.Properties.Resources.PapelJ;
            this.BtPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtPapel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtPapel.Location = new System.Drawing.Point(182, 264);
            this.BtPapel.Name = "BtPapel";
            this.BtPapel.Size = new System.Drawing.Size(142, 143);
            this.BtPapel.TabIndex = 1;
            this.BtPapel.Tag = "1";
            this.BtPapel.UseVisualStyleBackColor = false;
            this.BtPapel.Click += new System.EventHandler(this.ClickJogada);
            // 
            // BtTesoura
            // 
            this.BtTesoura.BackColor = System.Drawing.Color.White;
            this.BtTesoura.BackgroundImage = global::PedraPapelTesoura.Properties.Resources.TesouraJ;
            this.BtTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtTesoura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtTesoura.Location = new System.Drawing.Point(357, 264);
            this.BtTesoura.Name = "BtTesoura";
            this.BtTesoura.Size = new System.Drawing.Size(142, 143);
            this.BtTesoura.TabIndex = 2;
            this.BtTesoura.Tag = "2";
            this.BtTesoura.UseVisualStyleBackColor = false;
            this.BtTesoura.Click += new System.EventHandler(this.ClickJogada);
            // 
            // BtPedra
            // 
            this.BtPedra.BackColor = System.Drawing.Color.White;
            this.BtPedra.BackgroundImage = global::PedraPapelTesoura.Properties.Resources.PedraJ;
            this.BtPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtPedra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtPedra.Location = new System.Drawing.Point(12, 264);
            this.BtPedra.Name = "BtPedra";
            this.BtPedra.Size = new System.Drawing.Size(142, 143);
            this.BtPedra.TabIndex = 0;
            this.BtPedra.Tag = "0";
            this.BtPedra.UseVisualStyleBackColor = false;
            this.BtPedra.Click += new System.EventHandler(this.ClickJogada);
            // 
            // PicJogador
            // 
            this.PicJogador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicJogador.Location = new System.Drawing.Point(12, 70);
            this.PicJogador.Name = "PicJogador";
            this.PicJogador.Size = new System.Drawing.Size(150, 150);
            this.PicJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicJogador.TabIndex = 3;
            this.PicJogador.TabStop = false;
            // 
            // PicCpu
            // 
            this.PicCpu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicCpu.Location = new System.Drawing.Point(349, 70);
            this.PicCpu.Name = "PicCpu";
            this.PicCpu.Size = new System.Drawing.Size(150, 150);
            this.PicCpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCpu.TabIndex = 4;
            this.PicCpu.TabStop = false;
            // 
            // LbDescricaoJogador
            // 
            this.LbDescricaoJogador.AutoSize = true;
            this.LbDescricaoJogador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbDescricaoJogador.Location = new System.Drawing.Point(168, 125);
            this.LbDescricaoJogador.Name = "LbDescricaoJogador";
            this.LbDescricaoJogador.Size = new System.Drawing.Size(89, 19);
            this.LbDescricaoJogador.TabIndex = 5;
            this.LbDescricaoJogador.Text = "JOGADOR";
            this.LbDescricaoJogador.Click += new System.EventHandler(this.label1_Click);
            // 
            // LbDescricaoCpu
            // 
            this.LbDescricaoCpu.AutoSize = true;
            this.LbDescricaoCpu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbDescricaoCpu.Location = new System.Drawing.Point(296, 125);
            this.LbDescricaoCpu.Name = "LbDescricaoCpu";
            this.LbDescricaoCpu.Size = new System.Drawing.Size(44, 19);
            this.LbDescricaoCpu.TabIndex = 6;
            this.LbDescricaoCpu.Text = "CPU";
            this.LbDescricaoCpu.Click += new System.EventHandler(this.label2_Click);
            // 
            // LbPtJogador
            // 
            this.LbPtJogador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbPtJogador.Location = new System.Drawing.Point(182, 147);
            this.LbPtJogador.Name = "LbPtJogador";
            this.LbPtJogador.Size = new System.Drawing.Size(40, 20);
            this.LbPtJogador.TabIndex = 7;
            this.LbPtJogador.Text = "0";
            this.LbPtJogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbPtCpu
            // 
            this.LbPtCpu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbPtCpu.Location = new System.Drawing.Point(296, 147);
            this.LbPtCpu.Name = "LbPtCpu";
            this.LbPtCpu.Size = new System.Drawing.Size(40, 20);
            this.LbPtCpu.TabIndex = 8;
            this.LbPtCpu.Text = "0";
            this.LbPtCpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 435);
            this.Controls.Add(this.LbPtCpu);
            this.Controls.Add(this.LbPtJogador);
            this.Controls.Add(this.LbDescricaoCpu);
            this.Controls.Add(this.LbDescricaoJogador);
            this.Controls.Add(this.PicCpu);
            this.Controls.Add(this.PicJogador);
            this.Controls.Add(this.BtTesoura);
            this.Controls.Add(this.BtPapel);
            this.Controls.Add(this.BtPedra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedra, Papel, Tesoura - Pablo Rangel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BtPapel;
        private Button BtTesoura;
        private Button BtPedra;
        private PictureBox PicJogador;
        private PictureBox PicCpu;
        private Label LbDescricaoJogador;
        private Label LbDescricaoCpu;
        private Label LbPtJogador;
        private Label LbPtCpu;
    }
}