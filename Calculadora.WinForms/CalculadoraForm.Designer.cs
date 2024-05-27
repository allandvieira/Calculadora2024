namespace Calculadora.WinForms
{
    partial class CalculadoraForm
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
            label1 = new Label();
            label2 = new Label();
            txtPrimeiroNumero = new TextBox();
            txtSegundoNumero = new TextBox();
            rdbAdicao = new RadioButton();
            rdbSubtracao = new RadioButton();
            rdbMultiplicacao = new RadioButton();
            rdbDivisao = new RadioButton();
            btnCalcular = new Button();
            lblResultado = new Label();
            label4 = new Label();
            listHistoricoOperacoes = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 32);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Primeiro Número:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 61);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 1;
            label2.Text = "Segundo Número:";
            // 
            // txtPrimeiroNumero
            // 
            txtPrimeiroNumero.Location = new Point(144, 29);
            txtPrimeiroNumero.Name = "txtPrimeiroNumero";
            txtPrimeiroNumero.Size = new Size(212, 23);
            txtPrimeiroNumero.TabIndex = 2;
            // 
            // txtSegundoNumero
            // 
            txtSegundoNumero.Location = new Point(144, 58);
            txtSegundoNumero.Name = "txtSegundoNumero";
            txtSegundoNumero.Size = new Size(212, 23);
            txtSegundoNumero.TabIndex = 3;
            // 
            // rdbAdicao
            // 
            rdbAdicao.AutoSize = true;
            rdbAdicao.Location = new Point(38, 104);
            rdbAdicao.Name = "rdbAdicao";
            rdbAdicao.Size = new Size(62, 19);
            rdbAdicao.TabIndex = 4;
            rdbAdicao.TabStop = true;
            rdbAdicao.Text = "Adição";
            rdbAdicao.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracao
            // 
            rdbSubtracao.AutoSize = true;
            rdbSubtracao.Location = new Point(106, 104);
            rdbSubtracao.Name = "rdbSubtracao";
            rdbSubtracao.Size = new Size(78, 19);
            rdbSubtracao.TabIndex = 5;
            rdbSubtracao.TabStop = true;
            rdbSubtracao.Text = "Subtração";
            rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacao
            // 
            rdbMultiplicacao.AutoSize = true;
            rdbMultiplicacao.Location = new Point(190, 104);
            rdbMultiplicacao.Name = "rdbMultiplicacao";
            rdbMultiplicacao.Size = new Size(97, 19);
            rdbMultiplicacao.TabIndex = 6;
            rdbMultiplicacao.TabStop = true;
            rdbMultiplicacao.Text = "Multiplicação";
            rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbDivisao
            // 
            rdbDivisao.AutoSize = true;
            rdbDivisao.Location = new Point(293, 104);
            rdbDivisao.Name = "rdbDivisao";
            rdbDivisao.Size = new Size(63, 19);
            rdbDivisao.TabIndex = 7;
            rdbDivisao.TabStop = true;
            rdbDivisao.Text = "Divisão";
            rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(38, 140);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(318, 23);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(104, 166);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(100, 40);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 186);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 10;
            label4.Text = "Resultado:";
            // 
            // listHistoricoOperacoes
            // 
            listHistoricoOperacoes.FormattingEnabled = true;
            listHistoricoOperacoes.ItemHeight = 15;
            listHistoricoOperacoes.Location = new Point(38, 219);
            listHistoricoOperacoes.Name = "listHistoricoOperacoes";
            listHistoricoOperacoes.Size = new Size(318, 214);
            listHistoricoOperacoes.TabIndex = 11;
            // 
            // CalculadoraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 450);
            Controls.Add(listHistoricoOperacoes);
            Controls.Add(label4);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(rdbDivisao);
            Controls.Add(rdbMultiplicacao);
            Controls.Add(rdbSubtracao);
            Controls.Add(rdbAdicao);
            Controls.Add(txtSegundoNumero);
            Controls.Add(txtPrimeiroNumero);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CalculadoraForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Win 2024";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPrimeiroNumero;
        private TextBox txtSegundoNumero;
        private RadioButton rdbAdicao;
        private RadioButton rdbSubtracao;
        private RadioButton rdbMultiplicacao;
        private RadioButton rdbDivisao;
        private Button btnCalcular;
        private Label lblResultado;
        private Label label4;
        private ListBox listHistoricoOperacoes;
    }
}
