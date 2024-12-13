namespace WinFormsApp5
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
            lblRG = new Label();
            lblNome = new Label();
            lblCodigoCliente = new Label();
            lblCPF = new Label();
            cbbEstados = new ComboBox();
            lblEstado = new Label();
            txtNomeCompleto = new TextBox();
            txtIdCliente = new TextBox();
            gpbDadosPessoais = new GroupBox();
            mskNasc = new MaskedTextBox();
            mskCPF = new MaskedTextBox();
            mskRG = new MaskedTextBox();
            gpbSexo = new GroupBox();
            rdbFeminino = new RadioButton();
            rdbMasculino = new RadioButton();
            DataNasc = new Label();
            gpbContatos = new GroupBox();
            mskTelCelular = new MaskedTextBox();
            lblTelCll = new Label();
            btnInserir = new Button();
            button2 = new Button();
            btnSelect = new Button();
            button1 = new Button();
            gpbDadosPessoais.SuspendLayout();
            gpbSexo.SuspendLayout();
            gpbContatos.SuspendLayout();
            SuspendLayout();
            // 
            // lblRG
            // 
            lblRG.AutoSize = true;
            lblRG.Location = new Point(30, 218);
            lblRG.Name = "lblRG";
            lblRG.Size = new Size(22, 15);
            lblRG.TabIndex = 0;
            lblRG.Text = "RG";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(30, 95);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblCodigoCliente
            // 
            lblCodigoCliente.AutoSize = true;
            lblCodigoCliente.Location = new Point(30, 28);
            lblCodigoCliente.Name = "lblCodigoCliente";
            lblCodigoCliente.Size = new Size(86, 15);
            lblCodigoCliente.TabIndex = 2;
            lblCodigoCliente.Text = "Codigo Cliente";
            lblCodigoCliente.Click += label3_Click;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(245, 223);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 3;
            lblCPF.Text = "CPF";
            // 
            // cbbEstados
            // 
            cbbEstados.FormattingEnabled = true;
            cbbEstados.Items.AddRange(new object[] { "Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)", "Mato Grosso (MT)", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)", "Pará (PA)", "Paraíba (PB)", "Paraná (PR)", "Pernambuco (PE)", "Piauí (PI)", "Rio de Janeiro (RJ)", "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)", "Roraima (RR)", "Santa Catarina (SC)", "São Paulo (SP)", "Sergipe (SE)", "Tocantins (TO)" });
            cbbEstados.Location = new Point(394, 35);
            cbbEstados.Name = "cbbEstados";
            cbbEstados.Size = new Size(258, 23);
            cbbEstados.TabIndex = 5;
            cbbEstados.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(507, 19);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(116, 95);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(335, 23);
            txtNomeCompleto.TabIndex = 7;
            txtNomeCompleto.KeyPress += txtNomeCompleto_KeyPress;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(127, 25);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(157, 23);
            txtIdCliente.TabIndex = 8;
            txtIdCliente.TextChanged += textBox2_TextChanged;
            txtIdCliente.KeyPress += txtIdCliente_KeyPress;
            // 
            // gpbDadosPessoais
            // 
            gpbDadosPessoais.Controls.Add(mskNasc);
            gpbDadosPessoais.Controls.Add(mskCPF);
            gpbDadosPessoais.Controls.Add(mskRG);
            gpbDadosPessoais.Controls.Add(gpbSexo);
            gpbDadosPessoais.Controls.Add(DataNasc);
            gpbDadosPessoais.Controls.Add(txtIdCliente);
            gpbDadosPessoais.Controls.Add(txtNomeCompleto);
            gpbDadosPessoais.Controls.Add(lblCPF);
            gpbDadosPessoais.Controls.Add(lblCodigoCliente);
            gpbDadosPessoais.Controls.Add(lblNome);
            gpbDadosPessoais.Controls.Add(lblRG);
            gpbDadosPessoais.Location = new Point(12, 25);
            gpbDadosPessoais.Name = "gpbDadosPessoais";
            gpbDadosPessoais.Size = new Size(793, 258);
            gpbDadosPessoais.TabIndex = 11;
            gpbDadosPessoais.TabStop = false;
            gpbDadosPessoais.Text = "Dados Pessoais";
            // 
            // mskNasc
            // 
            mskNasc.Location = new Point(176, 161);
            mskNasc.Mask = "00/00/0000";
            mskNasc.Name = "mskNasc";
            mskNasc.Size = new Size(137, 23);
            mskNasc.TabIndex = 16;
            mskNasc.MaskInputRejected += mskNasc_MaskInputRejected;
            // 
            // mskCPF
            // 
            mskCPF.Location = new Point(303, 220);
            mskCPF.Mask = "999,999,999-99";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(121, 23);
            mskCPF.TabIndex = 15;
            // 
            // mskRG
            // 
            mskRG.Location = new Point(71, 218);
            mskRG.Mask = "99,999,999-a";
            mskRG.Name = "mskRG";
            mskRG.Size = new Size(123, 23);
            mskRG.TabIndex = 8;
            // 
            // gpbSexo
            // 
            gpbSexo.Controls.Add(rdbFeminino);
            gpbSexo.Controls.Add(rdbMasculino);
            gpbSexo.Location = new Point(520, 82);
            gpbSexo.Name = "gpbSexo";
            gpbSexo.Size = new Size(241, 62);
            gpbSexo.TabIndex = 14;
            gpbSexo.TabStop = false;
            gpbSexo.Text = "Sexo";
            // 
            // rdbFeminino
            // 
            rdbFeminino.AutoSize = true;
            rdbFeminino.Location = new Point(120, 19);
            rdbFeminino.Name = "rdbFeminino";
            rdbFeminino.Size = new Size(75, 19);
            rdbFeminino.TabIndex = 1;
            rdbFeminino.TabStop = true;
            rdbFeminino.Text = "Feminino";
            rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(20, 19);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(80, 19);
            rdbMasculino.TabIndex = 0;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // DataNasc
            // 
            DataNasc.AutoSize = true;
            DataNasc.Location = new Point(28, 161);
            DataNasc.Name = "DataNasc";
            DataNasc.Size = new Size(98, 15);
            DataNasc.TabIndex = 12;
            DataNasc.Text = "Data Nascimento";
            // 
            // gpbContatos
            // 
            gpbContatos.Controls.Add(mskTelCelular);
            gpbContatos.Controls.Add(lblTelCll);
            gpbContatos.Controls.Add(lblEstado);
            gpbContatos.Controls.Add(cbbEstados);
            gpbContatos.Location = new Point(25, 293);
            gpbContatos.Name = "gpbContatos";
            gpbContatos.Size = new Size(681, 126);
            gpbContatos.TabIndex = 12;
            gpbContatos.TabStop = false;
            gpbContatos.Text = "Contatos";
            // 
            // mskTelCelular
            // 
            mskTelCelular.Location = new Point(114, 35);
            mskTelCelular.Mask = "(99) 99999-9999";
            mskTelCelular.Name = "mskTelCelular";
            mskTelCelular.Size = new Size(121, 23);
            mskTelCelular.TabIndex = 17;
            // 
            // lblTelCll
            // 
            lblTelCll.AutoSize = true;
            lblTelCll.Location = new Point(17, 35);
            lblTelCll.Name = "lblTelCll";
            lblTelCll.Size = new Size(61, 15);
            lblTelCll.TabIndex = 7;
            lblTelCll.Text = "Tel Celular";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(139, 454);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(120, 48);
            btnInserir.TabIndex = 15;
            btnInserir.Text = "INSERIR";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // button2
            // 
            button2.Location = new Point(315, 454);
            button2.Name = "button2";
            button2.Size = new Size(129, 48);
            button2.TabIndex = 16;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(488, 454);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(144, 48);
            btnSelect.TabIndex = 17;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // button1
            // 
            button1.Location = new Point(681, 454);
            button1.Name = "button1";
            button1.Size = new Size(144, 48);
            button1.TabIndex = 17;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAtualizar;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 547);
            Controls.Add(button1);
            Controls.Add(btnSelect);
            Controls.Add(button2);
            Controls.Add(btnInserir);
            Controls.Add(gpbContatos);
            Controls.Add(gpbDadosPessoais);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gpbDadosPessoais.ResumeLayout(false);
            gpbDadosPessoais.PerformLayout();
            gpbSexo.ResumeLayout(false);
            gpbSexo.PerformLayout();
            gpbContatos.ResumeLayout(false);
            gpbContatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblRG;
        private Label lblNome;
        private Label lblCodigoCliente;
        private Label lblCPF;
        private ComboBox comboBox1;
        private Label lblEstado;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox gpbDadosPessoais;
        private Label DataNasc;
        private GroupBox gpbSexo;
        private RadioButton rdbFeminino;
        private RadioButton rdbMasculino;
        private GroupBox gpbContatos;
        private Label lblTelCll;
        private Button btnInserir;
        private Button button2;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox3;
        private ComboBox cbbEstados;
        private TextBox txtNomeCompleto;
        private TextBox txtIdCliente;
        private MaskedTextBox mskNasc;
        private MaskedTextBox mskCPF;
        private MaskedTextBox mskRG;
        private MaskedTextBox mskTelCelular;
        private Button btnSelect;
        private Button button1;
    }
}