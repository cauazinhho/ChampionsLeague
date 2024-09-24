namespace ChampionsLeague.View
{
    partial class Alterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alterar));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tbn_CodigoAtle = new TextBox();
            btn_Pesquisa = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            tbx_Assistencia = new TextBox();
            tbx_Posicao = new TextBox();
            tbx_Gols = new TextBox();
            tbx_TimeAtleta = new TextBox();
            tbx_NomeAtleta = new TextBox();
            btn_Alterar = new Button();
            btn_Excluir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(267, 22);
            label1.Name = "label1";
            label1.Size = new Size(237, 32);
            label1.TabIndex = 0;
            label1.Text = "Alteração de Dados";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(562, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 392);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 117);
            label2.Name = "label2";
            label2.Size = new Size(171, 21);
            label2.TabIndex = 2;
            label2.Text = "Digite Codigo do Atleta";
            // 
            // tbn_CodigoAtle
            // 
            tbn_CodigoAtle.Location = new Point(194, 117);
            tbn_CodigoAtle.Name = "tbn_CodigoAtle";
            tbn_CodigoAtle.Size = new Size(124, 23);
            tbn_CodigoAtle.TabIndex = 3;
            // 
            // btn_Pesquisa
            // 
            btn_Pesquisa.BackColor = Color.MediumOrchid;
            btn_Pesquisa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Pesquisa.ForeColor = SystemColors.InfoText;
            btn_Pesquisa.Location = new Point(339, 110);
            btn_Pesquisa.Name = "btn_Pesquisa";
            btn_Pesquisa.Size = new Size(120, 35);
            btn_Pesquisa.TabIndex = 4;
            btn_Pesquisa.Text = "Pesquisar";
            btn_Pesquisa.UseVisualStyleBackColor = false;
            btn_Pesquisa.Click += btn_Pesquisa_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 57);
            label3.Name = "label3";
            label3.Size = new Size(103, 17);
            label3.TabIndex = 5;
            label3.Text = "Digite os Dados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(40, 127);
            label4.Name = "label4";
            label4.Size = new Size(140, 17);
            label4.TabIndex = 6;
            label4.Text = "Nome do Novo Atleta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(47, 161);
            label5.Name = "label5";
            label5.Size = new Size(96, 17);
            label5.TabIndex = 7;
            label5.Text = "Time do Atleta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(71, 193);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 8;
            label6.Text = "Posição:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(71, 229);
            label7.Name = "label7";
            label7.Size = new Size(37, 17);
            label7.TabIndex = 9;
            label7.Text = "Gols:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(60, 269);
            label8.Name = "label8";
            label8.Size = new Size(74, 17);
            label8.TabIndex = 10;
            label8.Text = "Assistencia:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbx_Assistencia);
            groupBox1.Controls.Add(tbx_Posicao);
            groupBox1.Controls.Add(tbx_Gols);
            groupBox1.Controls.Add(tbx_TimeAtleta);
            groupBox1.Controls.Add(tbx_NomeAtleta);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(45, 180);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(446, 355);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alteração";
            // 
            // tbx_Assistencia
            // 
            tbx_Assistencia.Location = new Point(196, 263);
            tbx_Assistencia.Name = "tbx_Assistencia";
            tbx_Assistencia.Size = new Size(228, 23);
            tbx_Assistencia.TabIndex = 14;
            // 
            // tbx_Posicao
            // 
            tbx_Posicao.Location = new Point(196, 187);
            tbx_Posicao.Name = "tbx_Posicao";
            tbx_Posicao.Size = new Size(228, 23);
            tbx_Posicao.TabIndex = 13;
            // 
            // tbx_Gols
            // 
            tbx_Gols.Location = new Point(196, 224);
            tbx_Gols.Name = "tbx_Gols";
            tbx_Gols.Size = new Size(228, 23);
            tbx_Gols.TabIndex = 13;
            // 
            // tbx_TimeAtleta
            // 
            tbx_TimeAtleta.Location = new Point(196, 155);
            tbx_TimeAtleta.Name = "tbx_TimeAtleta";
            tbx_TimeAtleta.Size = new Size(228, 23);
            tbx_TimeAtleta.TabIndex = 12;
            // 
            // tbx_NomeAtleta
            // 
            tbx_NomeAtleta.Location = new Point(196, 121);
            tbx_NomeAtleta.Name = "tbx_NomeAtleta";
            tbx_NomeAtleta.Size = new Size(228, 23);
            tbx_NomeAtleta.TabIndex = 11;
            // 
            // btn_Alterar
            // 
            btn_Alterar.BackColor = SystemColors.HotTrack;
            btn_Alterar.ForeColor = SystemColors.ButtonHighlight;
            btn_Alterar.Location = new Point(45, 560);
            btn_Alterar.Name = "btn_Alterar";
            btn_Alterar.Size = new Size(216, 53);
            btn_Alterar.TabIndex = 12;
            btn_Alterar.Text = "Alterar Dados";
            btn_Alterar.UseVisualStyleBackColor = false;
            btn_Alterar.Click += btn_Alterar_Click;
            // 
            // btn_Excluir
            // 
            btn_Excluir.BackColor = SystemColors.HotTrack;
            btn_Excluir.ForeColor = SystemColors.ButtonHighlight;
            btn_Excluir.Location = new Point(275, 560);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(216, 53);
            btn_Excluir.TabIndex = 13;
            btn_Excluir.Text = "Excluir Dados";
            btn_Excluir.UseVisualStyleBackColor = false;
            btn_Excluir.Click += btn_Excluir_Click;
            // 
            // Alterar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 625);
            Controls.Add(btn_Excluir);
            Controls.Add(btn_Alterar);
            Controls.Add(groupBox1);
            Controls.Add(btn_Pesquisa);
            Controls.Add(tbn_CodigoAtle);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Alterar";
            Text = "Alterar";
            Load += Alterar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox tbn_CodigoAtle;
        private Button btn_Pesquisa;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private TextBox tbx_Posicao;
        private TextBox tbx_Gols;
        private TextBox tbx_TimeAtleta;
        private TextBox tbx_NomeAtleta;
        private TextBox tbx_Assistencia;
        private Button btn_Alterar;
        private Button btn_Excluir;
    }
}