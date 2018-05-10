namespace BaixaMassiva
{
    partial class Form1
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.botaoColar = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.OS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialInstalado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEquipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDeAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToOrderColumns = true;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OS,
            this.serialInstalado,
            this.TipoEquipamento,
            this.modelo,
            this.Tecnico,
            this.DataDeAtendimento,
            this.Resultado});
            this.grid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grid.Location = new System.Drawing.Point(12, 55);
            this.grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(864, 408);
            this.grid.TabIndex = 0;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCancelar.Location = new System.Drawing.Point(913, 409);
            this.botaoCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(132, 29);
            this.botaoCancelar.TabIndex = 1;
            this.botaoCancelar.Text = "Baixar OS";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // botaoColar
            // 
            this.botaoColar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoColar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoColar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botaoColar.Location = new System.Drawing.Point(732, 13);
            this.botaoColar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botaoColar.Name = "botaoColar";
            this.botaoColar.Size = new System.Drawing.Size(144, 30);
            this.botaoColar.TabIndex = 2;
            this.botaoColar.Text = "Colar planilha";
            this.botaoColar.UseVisualStyleBackColor = true;
            this.botaoColar.Click += new System.EventHandler(this.botaoColar_Click);
            // 
            // passwordField
            // 
            this.passwordField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordField.Location = new System.Drawing.Point(913, 334);
            this.passwordField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(132, 25);
            this.passwordField.TabIndex = 3;
            this.passwordField.UseSystemPasswordChar = true;
            this.passwordField.TextChanged += new System.EventHandler(this.passwordField_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(909, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Senha";
            // 
            // userField
            // 
            this.userField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userField.Location = new System.Drawing.Point(913, 242);
            this.userField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(132, 25);
            this.userField.TabIndex = 5;
            this.userField.TextChanged += new System.EventHandler(this.userField_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(909, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuário";
            // 
            // restart
            // 
            this.restart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restart.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.Location = new System.Drawing.Point(913, 13);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(132, 30);
            this.restart.TabIndex = 7;
            this.restart.Text = "Reiniciar";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // OS
            // 
            this.OS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OS.HeaderText = "OS";
            this.OS.Name = "OS";
            this.OS.Width = 50;
            // 
            // serialInstalado
            // 
            this.serialInstalado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.serialInstalado.HeaderText = "Serial Instalado";
            this.serialInstalado.Name = "serialInstalado";
            this.serialInstalado.Width = 125;
            // 
            // TipoEquipamento
            // 
            this.TipoEquipamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TipoEquipamento.HeaderText = "Tipo de Equipamento";
            this.TipoEquipamento.Name = "TipoEquipamento";
            this.TipoEquipamento.Width = 149;
            // 
            // modelo
            // 
            this.modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.Width = 79;
            // 
            // Tecnico
            // 
            this.Tecnico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tecnico.HeaderText = "Técnico";
            this.Tecnico.Name = "Tecnico";
            this.Tecnico.Width = 77;
            // 
            // DataDeAtendimento
            // 
            this.DataDeAtendimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DataDeAtendimento.HeaderText = "Data de Atendimento";
            this.DataDeAtendimento.Name = "DataDeAtendimento";
            this.DataDeAtendimento.Width = 150;
            // 
            // Resultado
            // 
            this.Resultado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Resultado.HeaderText = "Resultado";
            this.Resultado.Name = "Resultado";
            this.Resultado.Width = 93;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 476);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.botaoColar);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.grid);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Baixa Massiva Hijack";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Button botaoColar;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialInstalado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEquipamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDeAtendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
    }
}

