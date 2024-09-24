namespace ChampionsLeague.View
{
    partial class TelaCadastro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbx_Time = new TextBox();
            tbx_Nome = new TextBox();
            cbx_Posicao = new ComboBox();
            tbx_Assis = new TextBox();
            tbx_Gols = new TextBox();
            btn_Cancelar = new Button();
            btn_Salvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 42);
            label1.Name = "label1";
            label1.Size = new Size(259, 37);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Dados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(161, 205);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(161, 151);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(161, 260);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Posição:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(167, 323);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 4;
            label5.Text = "Gols:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(386, 323);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 5;
            label6.Text = "Assistencias:";
            // 
            // tbx_Time
            // 
            tbx_Time.Location = new Point(244, 152);
            tbx_Time.Name = "tbx_Time";
            tbx_Time.Size = new Size(220, 23);
            tbx_Time.TabIndex = 6;
            // 
            // tbx_Nome
            // 
            tbx_Nome.Location = new Point(244, 206);
            tbx_Nome.Name = "tbx_Nome";
            tbx_Nome.Size = new Size(220, 23);
            tbx_Nome.TabIndex = 7;
            // 
            // cbx_Posicao
            // 
            cbx_Posicao.FormattingEnabled = true;
            cbx_Posicao.Items.AddRange(new object[] { "Goleiro (GK)", "Lateral Direita (LD)", "Lateral Esquerda (LE)", "Zagueiro (ZAG)", "Volante (VOL)", "Meia Centra l(MC)", "Meia Atacante (MEI)", "Ponta Esquerda (PE)", "Ponta Direita (PD)", "Atacante (ATA)" });
            cbx_Posicao.Location = new Point(244, 260);
            cbx_Posicao.Name = "cbx_Posicao";
            cbx_Posicao.Size = new Size(220, 23);
            cbx_Posicao.TabIndex = 8;
            // 
            // tbx_Assis
            // 
            tbx_Assis.Location = new Point(386, 359);
            tbx_Assis.Name = "tbx_Assis";
            tbx_Assis.Size = new Size(78, 23);
            tbx_Assis.TabIndex = 10;
            // 
            // tbx_Gols
            // 
            tbx_Gols.Location = new Point(148, 359);
            tbx_Gols.Name = "tbx_Gols";
            tbx_Gols.Size = new Size(78, 23);
            tbx_Gols.TabIndex = 11;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = SystemColors.ActiveCaption;
            btn_Cancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn_Cancelar.ForeColor = SystemColors.ActiveCaptionText;
            btn_Cancelar.Location = new Point(117, 458);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(120, 45);
            btn_Cancelar.TabIndex = 12;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Salvar
            // 
            btn_Salvar.BackColor = SystemColors.ActiveCaption;
            btn_Salvar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn_Salvar.ForeColor = SystemColors.ActiveCaptionText;
            btn_Salvar.Location = new Point(373, 458);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(120, 45);
            btn_Salvar.TabIndex = 13;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.UseVisualStyleBackColor = false;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(585, 570);
            Controls.Add(btn_Salvar);
            Controls.Add(btn_Cancelar);
            Controls.Add(tbx_Gols);
            Controls.Add(tbx_Assis);
            Controls.Add(cbx_Posicao);
            Controls.Add(tbx_Nome);
            Controls.Add(tbx_Time);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaCadastro";
            ShowIcon = false;
            Text = "TelaCadastroJogadores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbx_Time;
        private TextBox tbx_Nome;
        private ComboBox cbx_Posicao;
        private TextBox tbx_Assis;
        private TextBox tbx_Gols;
        private Button btn_Cancelar;
        private Button btn_Salvar;
    }
}