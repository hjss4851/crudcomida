namespace receitas
{
    partial class cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_rendimento = new System.Windows.Forms.TextBox();
            this.txt_tempo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_modo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_itens = new System.Windows.Forms.TextBox();
            this.btn_sss = new System.Windows.Forms.Button();
            this.btn_busca = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(54, 85);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(133, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(458, 36);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(82, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "ADICIONAR";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(69, 43);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(190, 20);
            this.txt_pesquisa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pesquisa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rendimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tempo de preparo";
            // 
            // txt_rendimento
            // 
            this.txt_rendimento.Location = new System.Drawing.Point(27, 151);
            this.txt_rendimento.Name = "txt_rendimento";
            this.txt_rendimento.Size = new System.Drawing.Size(36, 20);
            this.txt_rendimento.TabIndex = 7;
            // 
            // txt_tempo
            // 
            this.txt_tempo.Location = new System.Drawing.Point(125, 151);
            this.txt_tempo.Name = "txt_tempo";
            this.txt_tempo.Size = new System.Drawing.Size(62, 20);
            this.txt_tempo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Modo de preparo";
            // 
            // txt_modo
            // 
            this.txt_modo.Location = new System.Drawing.Point(12, 221);
            this.txt_modo.Multiline = true;
            this.txt_modo.Name = "txt_modo";
            this.txt_modo.Size = new System.Drawing.Size(234, 96);
            this.txt_modo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ingredientes";
            // 
            // txt_itens
            // 
            this.txt_itens.Location = new System.Drawing.Point(299, 221);
            this.txt_itens.Multiline = true;
            this.txt_itens.Name = "txt_itens";
            this.txt_itens.Size = new System.Drawing.Size(226, 96);
            this.txt_itens.TabIndex = 12;
            // 
            // btn_sss
            // 
            this.btn_sss.Location = new System.Drawing.Point(458, 65);
            this.btn_sss.Name = "btn_sss";
            this.btn_sss.Size = new System.Drawing.Size(82, 23);
            this.btn_sss.TabIndex = 13;
            this.btn_sss.Text = "SALVAR";
            this.btn_sss.UseVisualStyleBackColor = true;
            this.btn_sss.Click += new System.EventHandler(this.btn_sss_Click);
            // 
            // btn_busca
            // 
            this.btn_busca.Location = new System.Drawing.Point(458, 94);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(82, 23);
            this.btn_busca.TabIndex = 14;
            this.btn_busca.Text = "BUSCAR";
            this.btn_busca.UseVisualStyleBackColor = true;
            this.btn_busca.Click += new System.EventHandler(this.btn_busca_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(458, 124);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(82, 23);
            this.btn_editar.TabIndex = 15;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(458, 153);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(82, 23);
            this.btn_excluir.TabIndex = 16;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 339);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_busca);
            this.Controls.Add(this.btn_sss);
            this.Controls.Add(this.txt_itens);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_modo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tempo);
            this.Controls.Add(this.txt_rendimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Name = "cadastro";
            this.Text = "cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_rendimento;
        private System.Windows.Forms.TextBox txt_tempo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_modo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_itens;
        private System.Windows.Forms.Button btn_sss;
        private System.Windows.Forms.Button btn_busca;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
    }
}