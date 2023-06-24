namespace WindowsFormsExemplos.Forms.Clientes
{
    partial class CadastroClienteForm
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
            labelNome = new Label();
            labelCpf = new Label();
            labelDataDeNascimento = new Label();
            labelComplemento = new Label();
            dateTimePickerDataNascimento = new DateTimePicker();
            labelNumero = new Label();
            textBoxNome = new TextBox();
            richTextBoxComplemento = new RichTextBox();
            labelEstado = new Label();
            labelBairro = new Label();
            labelCidade = new Label();
            labelCep = new Label();
            labelLogradouro = new Label();
            textBoxCidade = new TextBox();
            textBoxLogradouro = new TextBox();
            textBoxBairro = new TextBox();
            maskedTextBoxCpf = new MaskedTextBox();
            comboBoxEstado = new ComboBox();
            maskedTextBoxCep = new MaskedTextBox();
            textBoxNumero = new TextBox();
            buttonCadastrar = new Button();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 3);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            labelNome.Click += label1_Click;
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(12, 58);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(33, 20);
            labelCpf.TabIndex = 1;
            labelCpf.Text = "CPF";
            // 
            // labelDataDeNascimento
            // 
            labelDataDeNascimento.AutoSize = true;
            labelDataDeNascimento.Location = new Point(134, 58);
            labelDataDeNascimento.Name = "labelDataDeNascimento";
            labelDataDeNascimento.Size = new Size(145, 20);
            labelDataDeNascimento.TabIndex = 2;
            labelDataDeNascimento.Text = "Data de Nascimento";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(12, 342);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(104, 20);
            labelComplemento.TabIndex = 3;
            labelComplemento.Text = "Complemento";
            // 
            // dateTimePickerDataNascimento
            // 
            dateTimePickerDataNascimento.Format = DateTimePickerFormat.Short;
            dateTimePickerDataNascimento.Location = new Point(154, 79);
            dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            dateTimePickerDataNascimento.Size = new Size(216, 27);
            dateTimePickerDataNascimento.TabIndex = 4;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(12, 284);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(63, 20);
            labelNumero.TabIndex = 5;
            labelNumero.Text = "Número";
            labelNumero.Click += label5_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 26);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(358, 27);
            textBoxNome.TabIndex = 8;
            // 
            // richTextBoxComplemento
            // 
            richTextBoxComplemento.Location = new Point(12, 365);
            richTextBoxComplemento.Name = "richTextBoxComplemento";
            richTextBoxComplemento.Size = new Size(358, 243);
            richTextBoxComplemento.TabIndex = 9;
            richTextBoxComplemento.Text = "";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(12, 115);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(54, 20);
            labelEstado.TabIndex = 10;
            labelEstado.Text = "Estado";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(12, 178);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(49, 20);
            labelBairro.TabIndex = 12;
            labelBairro.Text = "Bairro";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(153, 115);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(56, 20);
            labelCidade.TabIndex = 14;
            labelCidade.Text = "Cidade";
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Location = new Point(153, 178);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(34, 20);
            labelCep.TabIndex = 16;
            labelCep.Text = "CEP";
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(12, 231);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(87, 20);
            labelLogradouro.TabIndex = 18;
            labelLogradouro.Text = "Logradouro";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(154, 137);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(216, 27);
            textBoxCidade.TabIndex = 19;
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(12, 254);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(358, 27);
            textBoxLogradouro.TabIndex = 20;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(12, 201);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(116, 27);
            textBoxBairro.TabIndex = 21;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(12, 81);
            maskedTextBoxCpf.Mask = "000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(94, 27);
            maskedTextBoxCpf.TabIndex = 22;
            maskedTextBoxCpf.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxEstado.Location = new Point(12, 137);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(116, 28);
            comboBoxEstado.TabIndex = 23;
            comboBoxEstado.SelectedIndexChanged += comboBoxEstado_SelectedIndexChanged;
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(154, 201);
            maskedTextBoxCep.Mask = "00000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(216, 27);
            maskedTextBoxCep.TabIndex = 24;
            maskedTextBoxCep.KeyDown += maskedTextBoxCep_KeyDown;
            maskedTextBoxCep.Leave += maskedTextBoxCep_Leave;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(12, 312);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(358, 27);
            textBoxNumero.TabIndex = 25;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(12, 624);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(358, 27);
            buttonCadastrar.TabIndex = 27;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // CadastroClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 671);
            Controls.Add(buttonCadastrar);
            Controls.Add(textBoxNumero);
            Controls.Add(maskedTextBoxCep);
            Controls.Add(comboBoxEstado);
            Controls.Add(maskedTextBoxCpf);
            Controls.Add(textBoxBairro);
            Controls.Add(textBoxLogradouro);
            Controls.Add(textBoxCidade);
            Controls.Add(labelLogradouro);
            Controls.Add(labelCep);
            Controls.Add(labelCidade);
            Controls.Add(labelBairro);
            Controls.Add(labelEstado);
            Controls.Add(richTextBoxComplemento);
            Controls.Add(textBoxNome);
            Controls.Add(labelNumero);
            Controls.Add(dateTimePickerDataNascimento);
            Controls.Add(labelComplemento);
            Controls.Add(labelDataDeNascimento);
            Controls.Add(labelCpf);
            Controls.Add(labelNome);
            Name = "CadastroClienteForm";
            Text = "CadastroClienteForm";
            Load += CadastroClienteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelCpf;
        private Label labelDataDeNascimento;
        private Label labelComplemento;
        private DateTimePicker dateTimePickerDataNascimento;
        private Label labelNumero;
        private TextBox textBoxNome;
        private RichTextBox richTextBoxComplemento;
        private Label labelEstado;
        private Label labelBairro;
        private Label labelCidade;
        private Label labelCep;
        private Label labelLogradouro;
        private TextBox textBoxCidade;
        private TextBox textBoxLogradouro;
        private TextBox textBoxBairro;
        private MaskedTextBox maskedTextBoxCpf;
        private ComboBox comboBoxEstado;
        private MaskedTextBox maskedTextBoxCep;
        private TextBox textBoxNumero;
        private Button buttonCadastrar;
    }
}