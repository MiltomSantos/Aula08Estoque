namespace Aula08Estoque
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeletarPrimeiroProduto = new System.Windows.Forms.Button();
            this.btnUltimoProduto = new System.Windows.Forms.Button();
            this.btnPrimeiroProduto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(146, 184);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 31);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(6, 184);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(134, 31);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(18, 135);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(245, 23);
            this.txtQuantidade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade em Estoque";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(18, 70);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(245, 23);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Produto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEstoque);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblCadastro);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(400, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblEstoque.Location = new System.Drawing.Point(130, 155);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(23, 25);
            this.lblEstoque.TabIndex = 3;
            this.lblEstoque.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(62, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Quantidade do Estoque:";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCadastro.Location = new System.Drawing.Point(130, 68);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(23, 25);
            this.lblCadastro.TabIndex = 1;
            this.lblCadastro.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(62, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Produtos Cadastrados:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeletarPrimeiroProduto);
            this.groupBox3.Controls.Add(this.btnUltimoProduto);
            this.groupBox3.Controls.Add(this.btnPrimeiroProduto);
            this.groupBox3.Location = new System.Drawing.Point(22, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(659, 168);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operações";
            // 
            // btnDeletarPrimeiroProduto
            // 
            this.btnDeletarPrimeiroProduto.Location = new System.Drawing.Point(440, 22);
            this.btnDeletarPrimeiroProduto.Name = "btnDeletarPrimeiroProduto";
            this.btnDeletarPrimeiroProduto.Size = new System.Drawing.Size(199, 46);
            this.btnDeletarPrimeiroProduto.TabIndex = 2;
            this.btnDeletarPrimeiroProduto.Text = "Deletar PRIMEIRO Produto";
            this.btnDeletarPrimeiroProduto.UseVisualStyleBackColor = true;
            this.btnDeletarPrimeiroProduto.Click += new System.EventHandler(this.btnDeletarPrimeiroProduto_Click);
            // 
            // btnUltimoProduto
            // 
            this.btnUltimoProduto.Location = new System.Drawing.Point(18, 89);
            this.btnUltimoProduto.Name = "btnUltimoProduto";
            this.btnUltimoProduto.Size = new System.Drawing.Size(199, 46);
            this.btnUltimoProduto.TabIndex = 1;
            this.btnUltimoProduto.Text = "Ver ULTIMO Produto";
            this.btnUltimoProduto.UseVisualStyleBackColor = true;
            this.btnUltimoProduto.Click += new System.EventHandler(this.btnUltimoProduto_Click);
            // 
            // btnPrimeiroProduto
            // 
            this.btnPrimeiroProduto.Location = new System.Drawing.Point(18, 22);
            this.btnPrimeiroProduto.Name = "btnPrimeiroProduto";
            this.btnPrimeiroProduto.Size = new System.Drawing.Size(199, 46);
            this.btnPrimeiroProduto.TabIndex = 0;
            this.btnPrimeiroProduto.Text = "Ver PRIMEIRO Produto";
            this.btnPrimeiroProduto.UseVisualStyleBackColor = true;
            this.btnPrimeiroProduto.Click += new System.EventHandler(this.btnPrimeiroProduto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(720, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSalvar;
        private TextBox txtQuantidade;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private GroupBox groupBox2;
        private Label lblEstoque;
        private Label label5;
        private Label lblCadastro;
        private Label label3;
        private GroupBox groupBox3;
        private Button btnDeletarPrimeiroProduto;
        private Button btnUltimoProduto;
        private Button btnPrimeiroProduto;
        private Button btnCancelar;
        private Button button1;
    }
}