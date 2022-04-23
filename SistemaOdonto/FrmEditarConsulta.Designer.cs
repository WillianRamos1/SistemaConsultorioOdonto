
namespace SistemaOdonto
{
    partial class FrmEditarConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarConsulta));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolNenhuma = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateTimeHora = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CBDentista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBPaciente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DateTimeData = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTimeFim = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolNenhuma});
            this.statusStrip1.Location = new System.Drawing.Point(0, 660);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1200, 32);
            this.statusStrip1.TabIndex = 65;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(104, 25);
            this.toolStripStatusLabel1.Text = "Mensagem:";
            // 
            // toolNenhuma
            // 
            this.toolNenhuma.Name = "toolNenhuma";
            this.toolNenhuma.Size = new System.Drawing.Size(80, 25);
            this.toolNenhuma.Text = "Nenhum";
            // 
            // DateTimeHora
            // 
            this.DateTimeHora.CustomFormat = "HH:mm";
            this.DateTimeHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeHora.Location = new System.Drawing.Point(756, 90);
            this.DateTimeHora.Name = "DateTimeHora";
            this.DateTimeHora.ShowUpDown = true;
            this.DateTimeHora.Size = new System.Drawing.Size(258, 26);
            this.DateTimeHora.TabIndex = 64;
            this.DateTimeHora.Value = new System.DateTime(2022, 4, 19, 10, 30, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Hora:";
            // 
            // CBDentista
            // 
            this.CBDentista.FormattingEnabled = true;
            this.CBDentista.Location = new System.Drawing.Point(187, 93);
            this.CBDentista.Name = "CBDentista";
            this.CBDentista.Size = new System.Drawing.Size(298, 28);
            this.CBDentista.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Dentista:";
            // 
            // CBPaciente
            // 
            this.CBPaciente.FormattingEnabled = true;
            this.CBPaciente.Location = new System.Drawing.Point(187, 34);
            this.CBPaciente.Name = "CBPaciente";
            this.CBPaciente.Size = new System.Drawing.Size(298, 28);
            this.CBPaciente.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "Paciente:";
            // 
            // DateTimeData
            // 
            this.DateTimeData.Location = new System.Drawing.Point(756, 32);
            this.DateTimeData.Name = "DateTimeData";
            this.DateTimeData.Size = new System.Drawing.Size(258, 26);
            this.DateTimeData.TabIndex = 58;
            this.DateTimeData.UseWaitCursor = true;
            this.DateTimeData.Value = new System.DateTime(2022, 3, 1, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(701, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "Data:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(187, 236);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(827, 99);
            this.txtObservacao.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 240);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "Anotações:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(135, 346);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(27, 20);
            this.lblCodigo.TabIndex = 69;
            this.lblCodigo.Text = "01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 346);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Codigo:";
            // 
            // DateTimeInicio
            // 
            this.DateTimeInicio.CustomFormat = "HH:mm";
            this.DateTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeInicio.Location = new System.Drawing.Point(187, 154);
            this.DateTimeInicio.Name = "DateTimeInicio";
            this.DateTimeInicio.ShowUpDown = true;
            this.DateTimeInicio.Size = new System.Drawing.Size(258, 26);
            this.DateTimeInicio.TabIndex = 71;
            this.DateTimeInicio.Value = new System.DateTime(2022, 4, 19, 10, 30, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Inicio:";
            // 
            // DateTimeFim
            // 
            this.DateTimeFim.CustomFormat = "HH:mm";
            this.DateTimeFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeFim.Location = new System.Drawing.Point(756, 153);
            this.DateTimeFim.Name = "DateTimeFim";
            this.DateTimeFim.ShowUpDown = true;
            this.DateTimeFim.Size = new System.Drawing.Size(258, 26);
            this.DateTimeFim.TabIndex = 73;
            this.DateTimeFim.Value = new System.DateTime(2022, 4, 19, 10, 30, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(701, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "Fim:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(567, 464);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 108);
            this.btnExcluir.TabIndex = 75;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(340, 464);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(105, 108);
            this.btnEditar.TabIndex = 74;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FrmEditarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.DateTimeFim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateTimeInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DateTimeHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBDentista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBPaciente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DateTimeData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.label7);
            this.Name = "FrmEditarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarConsulta";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolNenhuma;
        private System.Windows.Forms.DateTimePicker DateTimeHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBDentista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBPaciente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DateTimeData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateTimeInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateTimeFim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
    }
}