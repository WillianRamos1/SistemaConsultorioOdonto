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
    public partial class FrmCadConsulta : Form
    {
        ConsultaService service = new ConsultaService();
        DentistaService serviceDentista = new DentistaService();
        PacienteService servicePaciente = new PacienteService();
        public FrmCadConsulta()
        {
            InitializeComponent();
            IniciarForm();
        }

        private void IniciarForm()
        {
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            toolNenhuma.Text = "";
            try
            {
                toolStripStatusLabel1.Text = ValidarCad();
                if (toolStripStatusLabel1.Text == "Sucesso")
                {
                    service.Cadastrar(objGerado());
                    MessageBox.Show("Consulta efetuada com Sucesso");
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar: " + ex.Message);
            }
        }
        public Consulta objGerado()
        {
            Consulta obj = new Consulta();
            obj.IdDentista = Convert.ToInt32(CBDentista.SelectedValue);
            obj.IdPaciente = Convert.ToInt32(CBPaciente.SelectedValue);
            obj.Data = Convert.ToDateTime(DateTimeData.Value.ToString("dd/MM/yyyy"));
            obj.HoraMarcada = DateTimeHora.Value;
            obj.HoraInicio = Convert.ToDateTime("00:00");
            obj.HoraFim = Convert.ToDateTime("00:00");
            obj.Observacao = txtObservacao.Text;
            obj.Status = "Não Confirmado";
            return obj;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FrmConsultas frm = new FrmConsultas();
            frm.ShowDialog();
        }
    }
}
