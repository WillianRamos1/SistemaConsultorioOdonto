using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;

namespace SistemaOdonto
{
    public partial class FrmEditarConsulta : Form
    {
        Consulta consulta = new Consulta();
        ConsultaService service = new ConsultaService();
        DentistaService serviceDentista = new DentistaService();
        PacienteService servicePaciente = new PacienteService();

        public FrmEditarConsulta(Consulta c)
        {
            InitializeComponent();
            IniciarForm(c);
        }

        private void IniciarForm(Consulta c)
        {
            this.consulta = c;

            lblCodigo.Text = this.consulta.IdConsulta.ToString();
            CBPaciente.Text = servicePaciente.Buscar(this.consulta.IdPaciente).Nome;
            CBDentista.Text = serviceDentista.Buscar(this.consulta.IdDentista).Nome;
            DateTimeData.Text = this.consulta.Data.ToString();
            DateTimeHora.Text = this.consulta.HoraMarcada.ToString();
            DateTimeInicio.Text = this.consulta.HoraInicio.ToString();
            DateTimeFim.Text = this.consulta.HoraFim.ToString();
            txtObservacao.Text = this.consulta.Observacao;

            try
            {
                var lista = serviceDentista.Listar();
                var listaDentsta = new Dictionary<int, string>();
                listaDentsta.Add(0, "Selecione um Dentista");
                foreach (var item in lista)
                {
                    listaDentsta.Add(item.Id, item.Nome);
                }
                CBDentista.DataSource = new BindingSource(listaDentsta, null);
                CBDentista.DisplayMember = "value";
                CBDentista.ValueMember = "key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a Lista" + ex.Message);
            }

            try
            {
                var lista2 = servicePaciente.Listar();
                var listaPaciente = new Dictionary<int, string>();
                listaPaciente.Add(0, "Selecione um Paciente");
                foreach (var item in lista2)
                {
                    listaPaciente.Add(item.Id, item.Nome);
                }
                CBPaciente.DataSource = new BindingSource(listaPaciente, null);
                CBPaciente.DisplayMember = "value";
                CBPaciente.ValueMember = "key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a Lista" + ex.Message);
            }
        }

        private string ValidarCad()
        {
            toolStripStatusLabel1.ForeColor = Color.Red;
            if (Convert.ToInt32(CBDentista.SelectedValue) == 0)
            {
                return "Selecione um Dentista";
            }
            else if (Convert.ToInt32(CBPaciente.SelectedValue) == 0)
            {
                return "Selecione um Paciente";
            }
            else if (DateTimeData.Text == string.Empty)
            {
                return "Escolha uma Data";
            }
            else if (DateTimeHora.Text == string.Empty)
            {
                return "Escolha um Horario";
            }
            else
            {
                toolStripStatusLabel1.ForeColor = Color.Black;
                return "Sucesso";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = ValidarCad();
            toolNenhuma.Text = "";
            if (toolStripStatusLabel1.Text == "Sucesso")
            {
                this.consulta.IdPaciente = Convert.ToInt32(CBPaciente.SelectedItem);
                this.consulta.IdDentista = Convert.ToInt32(CBDentista.SelectedItem);
                this.consulta.Data = Convert.ToDateTime(DateTimeData.Text);
                this.consulta.HoraMarcada = Convert.ToDateTime(DateTimeHora.Text);
                this.consulta.HoraInicio = Convert.ToDateTime(DateTimeInicio.Text);
                this.consulta.HoraFim = Convert.ToDateTime(DateTimeFim.Text);
                this.consulta.Observacao = txtObservacao.Text;
                service.Editar(this.consulta);
                this.Close();
                }
            }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            toolNenhuma.Text = "";
            if (ValidarExclusao())
            {
                service.Deletar(this.consulta.IdConsulta);
                MessageBox.Show("Excluido com Sucesso");
                this.Close();
            }
        }

        private bool ValidarExclusao()
        {
            DialogResult con = MessageBox.Show("Deseja excluir esse registro ?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (con.ToString().ToUpper() == "YES")
                return true;
            else return false;
        }
    }
    }
