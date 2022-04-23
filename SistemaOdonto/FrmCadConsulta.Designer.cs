
namespace SistemaOdonto
{
    partial class FrmCadConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadConsulta));
            this.CBPaciente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CBDentista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimeHora = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolNenhuma = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.DateTimeFim = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTimeData = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBPaciente
            // 
            this.CBPaciente.FormattingEnabled = true;
            this.CBPaciente.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.CBPaciente.Location = new System.Drawing.Point(125, 43);
            this.CBPaciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBPaciente.Name = "CBPaciente";
            this.CBPaciente.Size = new System.Drawing.Size(200, 21);
            this.CBPaciente.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Paciente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Data:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(125, 150);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(553, 66);
            this.txtObservacao.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Anotações:";
            // 
            // CBDentista
            // 
            this.CBDentista.FormattingEnabled = true;
            this.CBDentista.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.CBDentista.Location = new System.Drawing.Point(125, 81);
            this.CBDentista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBDentista.Name = "CBDentista";
            this.CBDentista.Size = new System.Drawing.Size(200, 21);
            this.CBDentista.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Dentista:";
            // 
            // DateTimeHora
            // 
            this.DateTimeHora.CustomFormat = "HH:mm";
            this.DateTimeHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeHora.Location = new System.Drawing.Point(504, 79);
            this.DateTimeHora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTimeHora.Name = "DateTimeHora";
            this.DateTimeHora.ShowUpDown = true;
            this.DateTimeHora.Size = new System.Drawing.Size(173, 20);
            this.DateTimeHora.TabIndex = 51;
            this.DateTimeHora.Value = new System.DateTime(2022, 4, 20, 10, 30, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Hora:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolNenhuma});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 52;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel1.Text = "Mensagem:";
            // 
            // toolNenhuma
            // 
            this.toolNenhuma.Name = "toolNenhuma";
            this.toolNenhuma.Size = new System.Drawing.Size(54, 17);
            this.toolNenhuma.Text = "Nenhum";
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsulta.BackgroundImage")));
            this.btnConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Location = new System.Drawing.Point(437, 294);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(55, 55);
            this.btnConsulta.TabIndex = 54;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(269, 294);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(55, 55);
            this.btnSalvar.TabIndex = 53;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // DateTimeFim
            // 
            this.DateTimeFim.CustomFormat = "HH:mm";
            this.DateTimeFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeFim.Location = new System.Drawing.Point(504, 116);
            this.DateTimeFim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTimeFim.Name = "DateTimeFim";
            this.DateTimeFim.ShowUpDown = true;
            this.DateTimeFim.Size = new System.Drawing.Size(173, 20);
            this.DateTimeFim.TabIndex = 77;
            this.DateTimeFim.Value = new System.DateTime(2022, 4, 19, 10, 30, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Fim:";
            // 
            // DateTimeInicio
            // 
            this.DateTimeInicio.CustomFormat = "HH:mm";
            this.DateTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeInicio.Location = new System.Drawing.Point(125, 117);
            this.DateTimeInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTimeInicio.Name = "DateTimeInicio";
            this.DateTimeInicio.ShowUpDown = true;
            this.DateTimeInicio.Size = new System.Drawing.Size(173, 20);
            this.DateTimeInicio.TabIndex = 75;
            this.DateTimeInicio.Value = new System.DateTime(2022, 4, 19, 10, 30, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Inicio:";
            // 
            // DateTimeData
            // 
            this.DateTimeData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeData.Location = new System.Drawing.Point(504, 41);
            this.DateTimeData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTimeData.Name = "DateTimeData";
            this.DateTimeData.Size = new System.Drawing.Size(173, 20);
            this.DateTimeData.TabIndex = 78;
            // 
            // FrmCadConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DateTimeData);
            this.Controls.Add(this.DateTimeFim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateTimeInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DateTimeHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBDentista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBPaciente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCadConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Consultas";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBPaciente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBDentista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateTimeHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolNenhuma;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker DateTimeFim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateTimeInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateTimeData;
    }
}