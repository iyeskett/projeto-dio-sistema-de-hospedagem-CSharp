namespace SistemaDeHospedagem
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
            this.lblTipoSuite = new System.Windows.Forms.Label();
            this.lblCapacidade = new System.Windows.Forms.Label();
            this.lblValorDiaria = new System.Windows.Forms.Label();
            this.txtTipoSuite = new System.Windows.Forms.TextBox();
            this.txtCapacidade = new System.Windows.Forms.TextBox();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarSuite = new System.Windows.Forms.Button();
            this.btnCadastrarPessoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.lblReserva = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQuantidadeHospedes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnQuantidadeHospedes = new System.Windows.Forms.Button();
            this.btnValor = new System.Windows.Forms.Button();
            this.txtDiasReservados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTipoSuite
            // 
            this.lblTipoSuite.AutoSize = true;
            this.lblTipoSuite.Location = new System.Drawing.Point(12, 20);
            this.lblTipoSuite.Name = "lblTipoSuite";
            this.lblTipoSuite.Size = new System.Drawing.Size(76, 20);
            this.lblTipoSuite.TabIndex = 0;
            this.lblTipoSuite.Text = "Tipo Suíte";
            // 
            // lblCapacidade
            // 
            this.lblCapacidade.AutoSize = true;
            this.lblCapacidade.Location = new System.Drawing.Point(12, 56);
            this.lblCapacidade.Name = "lblCapacidade";
            this.lblCapacidade.Size = new System.Drawing.Size(88, 20);
            this.lblCapacidade.TabIndex = 1;
            this.lblCapacidade.Text = "Capacidade";
            // 
            // lblValorDiaria
            // 
            this.lblValorDiaria.AutoSize = true;
            this.lblValorDiaria.Location = new System.Drawing.Point(12, 89);
            this.lblValorDiaria.Name = "lblValorDiaria";
            this.lblValorDiaria.Size = new System.Drawing.Size(87, 20);
            this.lblValorDiaria.TabIndex = 2;
            this.lblValorDiaria.Text = "Valor Diária";
            // 
            // txtTipoSuite
            // 
            this.txtTipoSuite.Location = new System.Drawing.Point(114, 17);
            this.txtTipoSuite.Name = "txtTipoSuite";
            this.txtTipoSuite.Size = new System.Drawing.Size(125, 27);
            this.txtTipoSuite.TabIndex = 3;
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Location = new System.Drawing.Point(114, 50);
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(125, 27);
            this.txtCapacidade.TabIndex = 4;
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Location = new System.Drawing.Point(114, 83);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(125, 27);
            this.txtValorDiaria.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Suíte";
            // 
            // btnCadastrarSuite
            // 
            this.btnCadastrarSuite.Location = new System.Drawing.Point(12, 134);
            this.btnCadastrarSuite.Name = "btnCadastrarSuite";
            this.btnCadastrarSuite.Size = new System.Drawing.Size(227, 29);
            this.btnCadastrarSuite.TabIndex = 7;
            this.btnCadastrarSuite.Text = "Cadastrar Suíte";
            this.btnCadastrarSuite.UseVisualStyleBackColor = true;
            this.btnCadastrarSuite.Click += new System.EventHandler(this.btnCadastrarSuite_Click);
            // 
            // btnCadastrarPessoa
            // 
            this.btnCadastrarPessoa.Location = new System.Drawing.Point(300, 134);
            this.btnCadastrarPessoa.Name = "btnCadastrarPessoa";
            this.btnCadastrarPessoa.Size = new System.Drawing.Size(227, 29);
            this.btnCadastrarPessoa.TabIndex = 15;
            this.btnCadastrarPessoa.Text = "Cadastrar Pessoa";
            this.btnCadastrarPessoa.UseVisualStyleBackColor = true;
            this.btnCadastrarPessoa.Click += new System.EventHandler(this.btnCadastrarPessoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(300, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hóspede";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(402, 50);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(125, 27);
            this.txtSobrenome.TabIndex = 12;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(402, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(125, 27);
            this.txtNome.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sobrenome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome";
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(153, 227);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(227, 29);
            this.btnReservar.TabIndex = 21;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReserva.Location = new System.Drawing.Point(114, 291);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(65, 20);
            this.lblReserva.TabIndex = 20;
            this.lblReserva.Text = "Reserva";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(298, 344);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(125, 27);
            this.txtValor.TabIndex = 19;
            // 
            // txtQuantidadeHospedes
            // 
            this.txtQuantidadeHospedes.Location = new System.Drawing.Point(298, 311);
            this.txtQuantidadeHospedes.Name = "txtQuantidadeHospedes";
            this.txtQuantidadeHospedes.ReadOnly = true;
            this.txtQuantidadeHospedes.Size = new System.Drawing.Size(125, 27);
            this.txtQuantidadeHospedes.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quantidade de Hóspedes";
            // 
            // btnQuantidadeHospedes
            // 
            this.btnQuantidadeHospedes.Location = new System.Drawing.Point(12, 409);
            this.btnQuantidadeHospedes.Name = "btnQuantidadeHospedes";
            this.btnQuantidadeHospedes.Size = new System.Drawing.Size(227, 29);
            this.btnQuantidadeHospedes.TabIndex = 22;
            this.btnQuantidadeHospedes.Text = "Quantidade de Hóspedes";
            this.btnQuantidadeHospedes.UseVisualStyleBackColor = true;
            this.btnQuantidadeHospedes.Click += new System.EventHandler(this.btnQuantidadeHospedes_Click);
            // 
            // btnValor
            // 
            this.btnValor.Location = new System.Drawing.Point(298, 409);
            this.btnValor.Name = "btnValor";
            this.btnValor.Size = new System.Drawing.Size(229, 29);
            this.btnValor.TabIndex = 23;
            this.btnValor.Text = "Valor";
            this.btnValor.UseVisualStyleBackColor = true;
            this.btnValor.Click += new System.EventHandler(this.btnValor_Click);
            // 
            // txtDiasReservados
            // 
            this.txtDiasReservados.Location = new System.Drawing.Point(276, 198);
            this.txtDiasReservados.Name = "txtDiasReservados";
            this.txtDiasReservados.Size = new System.Drawing.Size(104, 27);
            this.txtDiasReservados.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Dias Reservados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.txtDiasReservados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnValor);
            this.Controls.Add(this.btnQuantidadeHospedes);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.lblReserva);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtQuantidadeHospedes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCadastrarPessoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCadastrarSuite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorDiaria);
            this.Controls.Add(this.txtCapacidade);
            this.Controls.Add(this.txtTipoSuite);
            this.Controls.Add(this.lblValorDiaria);
            this.Controls.Add(this.lblCapacidade);
            this.Controls.Add(this.lblTipoSuite);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTipoSuite;
        private Label lblCapacidade;
        private Label lblValorDiaria;
        private TextBox txtTipoSuite;
        private TextBox txtCapacidade;
        private TextBox txtValorDiaria;
        private Label label1;
        private Button btnCadastrarSuite;
        private Button btnCadastrarPessoa;
        private Label label2;
        private TextBox txtSobrenome;
        private TextBox txtNome;
        private Label label4;
        private Label label5;
        private Button btnReservar;
        private Label lblReserva;
        private TextBox txtValor;
        private TextBox txtQuantidadeHospedes;
        private Label label6;
        private Label label7;
        private Button btnQuantidadeHospedes;
        private Button btnValor;
        private TextBox txtDiasReservados;
        private Label label3;
    }
}