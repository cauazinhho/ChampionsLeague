namespace ChampionsLeague.View
{
    partial class TelaPesquisaPorNome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisaPorNome));
            label1 = new Label();
            label2 = new Label();
            tbx_PesquisaAtleta = new TextBox();
            dataGridView1 = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            time = new DataGridViewTextBoxColumn();
            posicao = new DataGridViewTextBoxColumn();
            gols = new DataGridViewTextBoxColumn();
            asst = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btn_Pesquisa = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, 24);
            label1.Name = "label1";
            label1.Size = new Size(213, 37);
            label1.TabIndex = 0;
            label1.Text = "Pesquisa Atleta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 104);
            label2.Name = "label2";
            label2.Size = new Size(154, 17);
            label2.TabIndex = 1;
            label2.Text = "Digite o Nome do Atleta:";
            // 
            // tbx_PesquisaAtleta
            // 
            tbx_PesquisaAtleta.Location = new Point(279, 103);
            tbx_PesquisaAtleta.Name = "tbx_PesquisaAtleta";
            tbx_PesquisaAtleta.Size = new Size(120, 23);
            tbx_PesquisaAtleta.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.HotTrack;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, time, posicao, gols, asst });
            dataGridView1.Location = new Point(9, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(599, 149);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            // 
            // time
            // 
            time.HeaderText = "Time";
            time.Name = "time";
            // 
            // posicao
            // 
            posicao.HeaderText = "Posição";
            posicao.Name = "posicao";
            // 
            // gols
            // 
            gols.HeaderText = "Gols";
            gols.Name = "gols";
            // 
            // asst
            // 
            asst.HeaderText = "Assistencias";
            asst.Name = "asst";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(119, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(624, 217);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estatisticas";
            // 
            // btn_Pesquisa
            // 
            btn_Pesquisa.BackColor = Color.MediumOrchid;
            btn_Pesquisa.Location = new Point(448, 95);
            btn_Pesquisa.Name = "btn_Pesquisa";
            btn_Pesquisa.Size = new Size(164, 36);
            btn_Pesquisa.TabIndex = 6;
            btn_Pesquisa.Text = "Pesquisar";
            btn_Pesquisa.UseVisualStyleBackColor = false;
            btn_Pesquisa.Click += btn_Pesquisa_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(119, 376);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(624, 304);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // TelaPesquisaPorNome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 726);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Pesquisa);
            Controls.Add(groupBox1);
            Controls.Add(tbx_PesquisaAtleta);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaPesquisaPorNome";
            Text = "TelaPesquisaPorNome";
            Load += TelaPesquisaPorNome_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbx_PesquisaAtleta;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn posicao;
        private DataGridViewTextBoxColumn gols;
        private DataGridViewTextBoxColumn asst;
        private GroupBox groupBox1;
        private Button btn_Pesquisa;
        private PictureBox pictureBox1;
    }
}