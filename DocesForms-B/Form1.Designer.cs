namespace DocesForms_B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblNome = new Label();
            txtNome = new TextBox();
            btnCalcular = new Button();
            txtPrecoUnitario = new TextBox();
            lblPrecoUnitario = new Label();
            txtQuantidade = new TextBox();
            lblQuantidade = new Label();
            txtIdadeCliente = new TextBox();
            lblIdadeCliente = new Label();
            lblDesconto = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Papyrus", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = SystemColors.ControlLightLight;
            lblNome.Location = new Point(86, 142);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(119, 27);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome Doce:";
            lblNome.Click += label1_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.Black;
            txtNome.Location = new Point(201, 140);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Doces do Chad";
            txtNome.Size = new Size(336, 33);
            txtNome.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.ControlDark;
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.FlatAppearance.BorderColor = Color.Black;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Papyrus", 15F);
            btnCalcular.ForeColor = SystemColors.ControlText;
            btnCalcular.Location = new Point(101, 379);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(104, 41);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtPrecoUnitario
            // 
            txtPrecoUnitario.Cursor = Cursors.IBeam;
            txtPrecoUnitario.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecoUnitario.Location = new Point(201, 191);
            txtPrecoUnitario.Name = "txtPrecoUnitario";
            txtPrecoUnitario.PlaceholderText = "Preço Unitário Chad";
            txtPrecoUnitario.Size = new Size(336, 33);
            txtPrecoUnitario.TabIndex = 4;
            // 
            // lblPrecoUnitario
            // 
            lblPrecoUnitario.AutoSize = true;
            lblPrecoUnitario.BackColor = Color.Transparent;
            lblPrecoUnitario.Font = new Font("Papyrus", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecoUnitario.ForeColor = SystemColors.ControlLightLight;
            lblPrecoUnitario.Location = new Point(62, 193);
            lblPrecoUnitario.Name = "lblPrecoUnitario";
            lblPrecoUnitario.Size = new Size(138, 27);
            lblPrecoUnitario.TabIndex = 3;
            lblPrecoUnitario.Text = "Preço Unitário:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Cursor = Cursors.IBeam;
            txtQuantidade.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantidade.Location = new Point(201, 245);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PlaceholderText = "Quantidade Chad";
            txtQuantidade.Size = new Size(336, 33);
            txtQuantidade.TabIndex = 6;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.BackColor = Color.Transparent;
            lblQuantidade.Font = new Font("Papyrus", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidade.ForeColor = SystemColors.ControlLightLight;
            lblQuantidade.Location = new Point(86, 247);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(116, 27);
            lblQuantidade.TabIndex = 5;
            lblQuantidade.Text = "Quantidade:";
            // 
            // txtIdadeCliente
            // 
            txtIdadeCliente.Cursor = Cursors.IBeam;
            txtIdadeCliente.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdadeCliente.Location = new Point(201, 297);
            txtIdadeCliente.Name = "txtIdadeCliente";
            txtIdadeCliente.PlaceholderText = "Idade do Cliente Chad";
            txtIdadeCliente.Size = new Size(336, 33);
            txtIdadeCliente.TabIndex = 8;
            // 
            // lblIdadeCliente
            // 
            lblIdadeCliente.AutoSize = true;
            lblIdadeCliente.BackColor = Color.Transparent;
            lblIdadeCliente.Font = new Font("Papyrus", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdadeCliente.ForeColor = SystemColors.ControlLightLight;
            lblIdadeCliente.Location = new Point(70, 299);
            lblIdadeCliente.Name = "lblIdadeCliente";
            lblIdadeCliente.Size = new Size(130, 27);
            lblIdadeCliente.TabIndex = 7;
            lblIdadeCliente.Text = "Idade Cliente:";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.BackColor = Color.Transparent;
            lblDesconto.Font = new Font("Papyrus", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesconto.ForeColor = SystemColors.ControlLightLight;
            lblDesconto.Location = new Point(100, 445);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(100, 27);
            lblDesconto.TabIndex = 9;
            lblDesconto.Text = "Desconto:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(771, 510);
            Controls.Add(lblDesconto);
            Controls.Add(txtIdadeCliente);
            Controls.Add(lblIdadeCliente);
            Controls.Add(txtQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(txtPrecoUnitario);
            Controls.Add(lblPrecoUnitario);
            Controls.Add(btnCalcular);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Button btnCalcular;
        private TextBox txtPrecoUnitario;
        private Label lblPrecoUnitario;
        private TextBox txtQuantidade;
        private Label lblQuantidade;
        private TextBox txtIdadeCliente;
        private Label lblIdadeCliente;
        private Label lblDesconto;
    }
}
