
namespace SistemaOdonto
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.CBDentista = new System.Windows.Forms.ComboBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.CodigoPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnotacoes = new System.Windows.Forms.Button();
            this.Anotacoes = new System.Windows.Forms.FlowLayoutPanel();
            this.PainelMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSuporte = new System.Windows.Forms.Button();
            this.btnConsultaGeral = new System.Windows.Forms.Button();
            this.btnConsultaPaciente = new System.Windows.Forms.Button();
            this.btnConsultaDentista = new System.Windows.Forms.Button();
            this.btnCadastroConsultas = new System.Windows.Forms.Button();
            this.btnCadastroPacientes = new System.Windows.Forms.Button();
            this.btnCadastroDentistas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.PainelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultas do Dia:";
            // 
            // CBDentista
            // 
            this.CBDentista.FormattingEnabled = true;
            this.CBDentista.Location = new System.Drawing.Point(439, 117);
            this.CBDentista.Name = "CBDentista";
            this.CBDentista.Size = new System.Drawing.Size(338, 21);
            this.CBDentista.TabIndex = 2;
            this.CBDentista.SelectionChangeCommitted += new System.EventHandler(this.CBDentista_SelectionChangeCommitted);
            this.CBDentista.Click += new System.EventHandler(this.CBDentista_Click);
            // 
            // DataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Hora,
            this.Paciente,
            this.Status,
            this.CodigoPaciente});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.Location = new System.Drawing.Point(308, 163);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 62;
            this.DataGrid.RowTemplate.Height = 28;
            this.DataGrid.Size = new System.Drawing.Size(635, 776);
            this.DataGrid.TabIndex = 3;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "ColunaCodigo";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = false;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 8;
            this.Hora.Name = "Hora";
            // 
            // Paciente
            // 
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.MinimumWidth = 8;
            this.Paciente.Name = "Paciente";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            // 
            // CodigoPaciente
            // 
            this.CodigoPaciente.HeaderText = "CodigoPaciente";
            this.CodigoPaciente.MinimumWidth = 8;
            this.CodigoPaciente.Name = "CodigoPaciente";
            this.CodigoPaciente.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(965, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Anotações:";
            // 
            // btnAnotacoes
            // 
            this.btnAnotacoes.BackColor = System.Drawing.Color.LightGray;
            this.btnAnotacoes.FlatAppearance.BorderSize = 0;
            this.btnAnotacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnotacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnotacoes.Location = new System.Drawing.Point(1050, 108);
            this.btnAnotacoes.Name = "btnAnotacoes";
            this.btnAnotacoes.Size = new System.Drawing.Size(62, 48);
            this.btnAnotacoes.TabIndex = 7;
            this.btnAnotacoes.Text = "+";
            this.btnAnotacoes.UseVisualStyleBackColor = false;
            this.btnAnotacoes.Click += new System.EventHandler(this.btnAnotacoes_Click);
            // 
            // Anotacoes
            // 
            this.Anotacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Anotacoes.AutoSize = true;
            this.Anotacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Anotacoes.Location = new System.Drawing.Point(968, 163);
            this.Anotacoes.Name = "Anotacoes";
            this.Anotacoes.Size = new System.Drawing.Size(804, 776);
            this.Anotacoes.TabIndex = 8;
            // 
            // PainelMenu
            // 
            this.PainelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PainelMenu.AutoSize = true;
            this.PainelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.PainelMenu.Controls.Add(this.label4);
            this.PainelMenu.Controls.Add(this.btnSair);
            this.PainelMenu.Controls.Add(this.btnSuporte);
            this.PainelMenu.Controls.Add(this.btnConsultaGeral);
            this.PainelMenu.Controls.Add(this.btnConsultaPaciente);
            this.PainelMenu.Controls.Add(this.btnConsultaDentista);
            this.PainelMenu.Controls.Add(this.btnCadastroConsultas);
            this.PainelMenu.Controls.Add(this.btnCadastroPacientes);
            this.PainelMenu.Controls.Add(this.btnCadastroDentistas);
            this.PainelMenu.Location = new System.Drawing.Point(-1, -1);
            this.PainelMenu.Name = "PainelMenu";
            this.PainelMenu.Size = new System.Drawing.Size(306, 961);
            this.PainelMenu.TabIndex = 9;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.Location = new System.Drawing.Point(3, 561);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(300, 50);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSuporte
            // 
            this.btnSuporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnSuporte.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSuporte.FlatAppearance.BorderSize = 0;
            this.btnSuporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuporte.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuporte.ForeColor = System.Drawing.Color.Transparent;
            this.btnSuporte.Location = new System.Drawing.Point(3, 505);
            this.btnSuporte.Name = "btnSuporte";
            this.btnSuporte.Size = new System.Drawing.Size(300, 50);
            this.btnSuporte.TabIndex = 6;
            this.btnSuporte.Text = "Suporte";
            this.btnSuporte.UseVisualStyleBackColor = false;
            this.btnSuporte.Click += new System.EventHandler(this.btnSuporte_Click);
            // 
            // btnConsultaGeral
            // 
            this.btnConsultaGeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnConsultaGeral.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnConsultaGeral.FlatAppearance.BorderSize = 0;
            this.btnConsultaGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaGeral.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaGeral.ForeColor = System.Drawing.Color.Transparent;
            this.btnConsultaGeral.Location = new System.Drawing.Point(3, 428);
            this.btnConsultaGeral.Name = "btnConsultaGeral";
            this.btnConsultaGeral.Size = new System.Drawing.Size(300, 50);
            this.btnConsultaGeral.TabIndex = 5;
            this.btnConsultaGeral.Text = "Agenda de Consultas Geral";
            this.btnConsultaGeral.UseVisualStyleBackColor = false;
            this.btnConsultaGeral.Click += new System.EventHandler(this.btnConsultaGeral_Click);
            // 
            // btnConsultaPaciente
            // 
            this.btnConsultaPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnConsultaPaciente.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnConsultaPaciente.FlatAppearance.BorderSize = 0;
            this.btnConsultaPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaPaciente.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaPaciente.ForeColor = System.Drawing.Color.Transparent;
            this.btnConsultaPaciente.Location = new System.Drawing.Point(3, 372);
            this.btnConsultaPaciente.Name = "btnConsultaPaciente";
            this.btnConsultaPaciente.Size = new System.Drawing.Size(300, 50);
            this.btnConsultaPaciente.TabIndex = 4;
            this.btnConsultaPaciente.Text = "Consultas de Pacientes";
            this.btnConsultaPaciente.UseVisualStyleBackColor = false;
            this.btnConsultaPaciente.Click += new System.EventHandler(this.btnConsultaPaciente_Click);
            // 
            // btnConsultaDentista
            // 
            this.btnConsultaDentista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnConsultaDentista.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnConsultaDentista.FlatAppearance.BorderSize = 0;
            this.btnConsultaDentista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaDentista.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaDentista.ForeColor = System.Drawing.Color.Transparent;
            this.btnConsultaDentista.Location = new System.Drawing.Point(3, 315);
            this.btnConsultaDentista.Name = "btnConsultaDentista";
            this.btnConsultaDentista.Size = new System.Drawing.Size(300, 50);
            this.btnConsultaDentista.TabIndex = 3;
            this.btnConsultaDentista.Text = "Consultas de Dentistas";
            this.btnConsultaDentista.UseVisualStyleBackColor = false;
            this.btnConsultaDentista.Click += new System.EventHandler(this.btnConsultaDentista_Click);
            // 
            // btnCadastroConsultas
            // 
            this.btnCadastroConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnCadastroConsultas.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCadastroConsultas.FlatAppearance.BorderSize = 0;
            this.btnCadastroConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroConsultas.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroConsultas.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastroConsultas.Location = new System.Drawing.Point(3, 245);
            this.btnCadastroConsultas.Name = "btnCadastroConsultas";
            this.btnCadastroConsultas.Size = new System.Drawing.Size(300, 50);
            this.btnCadastroConsultas.TabIndex = 2;
            this.btnCadastroConsultas.Text = "Cadastro de Consultas";
            this.btnCadastroConsultas.UseVisualStyleBackColor = false;
            this.btnCadastroConsultas.Click += new System.EventHandler(this.btnCadastroConsultas_Click);
            // 
            // btnCadastroPacientes
            // 
            this.btnCadastroPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnCadastroPacientes.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCadastroPacientes.FlatAppearance.BorderSize = 0;
            this.btnCadastroPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroPacientes.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroPacientes.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastroPacientes.Location = new System.Drawing.Point(3, 189);
            this.btnCadastroPacientes.Name = "btnCadastroPacientes";
            this.btnCadastroPacientes.Size = new System.Drawing.Size(300, 50);
            this.btnCadastroPacientes.TabIndex = 1;
            this.btnCadastroPacientes.Text = "Cadastro de Pacientes";
            this.btnCadastroPacientes.UseVisualStyleBackColor = false;
            this.btnCadastroPacientes.Click += new System.EventHandler(this.btnCadastroPacientes_Click);
            // 
            // btnCadastroDentistas
            // 
            this.btnCadastroDentistas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnCadastroDentistas.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCadastroDentistas.FlatAppearance.BorderSize = 0;
            this.btnCadastroDentistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroDentistas.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroDentistas.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastroDentistas.Location = new System.Drawing.Point(3, 133);
            this.btnCadastroDentistas.Name = "btnCadastroDentistas";
            this.btnCadastroDentistas.Size = new System.Drawing.Size(300, 50);
            this.btnCadastroDentistas.TabIndex = 0;
            this.btnCadastroDentistas.Text = "Cadastro de Dentistas";
            this.btnCadastroDentistas.UseVisualStyleBackColor = false;
            this.btnCadastroDentistas.Click += new System.EventHandler(this.btnCadastroDentistas_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Location = new System.Drawing.Point(304, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1484, 30);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(311, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pagina Inicial";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 62);
            this.label4.TabIndex = 12;
            this.label4.Text = "SISTEMA ODONTO\r\nV1.0\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1784, 951);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PainelMenu);
            this.Controls.Add(this.Anotacoes);
            this.Controls.Add(this.btnAnotacoes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.CBDentista);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Odonto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.PainelMenu.ResumeLayout(false);
            this.PainelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBDentista;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewLinkColumn Paciente;
        private System.Windows.Forms.DataGridViewImageColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnotacoes;
        private System.Windows.Forms.FlowLayoutPanel Anotacoes;
        private System.Windows.Forms.Panel PainelMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSuporte;
        private System.Windows.Forms.Button btnConsultaGeral;
        private System.Windows.Forms.Button btnConsultaPaciente;
        private System.Windows.Forms.Button btnConsultaDentista;
        private System.Windows.Forms.Button btnCadastroConsultas;
        private System.Windows.Forms.Button btnCadastroPacientes;
        private System.Windows.Forms.Button btnCadastroDentistas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

