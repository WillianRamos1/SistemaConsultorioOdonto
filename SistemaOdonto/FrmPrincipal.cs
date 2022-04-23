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
    public partial class FrmPrincipal : Form
    {
        ConsultaService service = new ConsultaService();
        DentistaService serviceDentista = new DentistaService();
        PacienteService servicePaciente = new PacienteService();
        public FrmPrincipal()
        {
            InitializeComponent();
            IniciarForm();
        }

        private void IniciarForm()
        {
            AtualizarCB();

        }
        private void AtualizarCB()
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

                AtualizarAgenda(Convert.ToInt32(CBDentista.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a Lista" + ex.Message);
            }
        }
        private void AtualizarAgenda(int id)
        {
            Dentista dentista = new Dentista();
            dentista = serviceDentista.Buscar(id);
            if (dentista != null)
            {
                DataGrid.Rows.Clear();
                GerarConsulta(dentista);
            }
        }
        private void GerarConsulta(Dentista dentista)
        {
            var con = service.Buscar(dentista, Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"))).OrderBy(x => x.HoraMarcada);
            if (con == null)
            {
                MessageBox.Show("Esse Dentista Não Tem Atendimentos Hoje");
            }
            else
            {
                foreach (var item in con)
                {
                    int linha = DataGrid.Rows.Add();
                    DataGrid.Rows[linha].Cells[0].Value = item.IdConsulta;
                    DataGrid.Rows[linha].Cells[1].Value = item.HoraMarcada.Value.ToString("HH:mm");
                    DataGrid.Rows[linha].Cells[2].Value = servicePaciente.Buscar(item.IdPaciente).Nome;
                    DataGrid.Rows[linha].Cells[3].Value = imagemStatus(item.Status);
                    DataGrid.Rows[linha].Cells[4].Value = item.IdPaciente;
                }
            }
        }
        private Bitmap imagemStatus(string s)
        {
            var imagem = new Bitmap(Properties.Resources.gray);
            switch (s)
            {
                case "Confirmado":
                    imagem = new Bitmap(Properties.Resources.blue);
                    break;

                case "Desmarcado":
                    imagem = new Bitmap(Properties.Resources.red);
                    break;

                case "Não Confirmado":
                    imagem = new Bitmap(Properties.Resources.gray);
                    break;

                case "Já Chegou":
                    imagem = new Bitmap(Properties.Resources.orange);
                    break;

                case "Em Atendimento":
                    imagem = new Bitmap(Properties.Resources.green);
                    break;

                default:
                    imagem = new Bitmap(Properties.Resources.address);
                    break;
            }
            return imagem;
        }
        private void CBDentista_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AtualizarAgenda(Convert.ToInt32(CBDentista.SelectedValue));
        }
        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                DataGridView dg = sender as DataGridView;
                int id = Convert.ToInt32(dg.Rows[e.RowIndex].Cells[4].Value);
                Paciente paciente = servicePaciente.Buscar(id);
                FrmEditarPaciente frm = new FrmEditarPaciente(paciente);
                frm.ShowDialog();
            }
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                int id = Convert.ToInt32(DataGrid.Rows[e.RowIndex].Cells[0].Value);
                Consulta consulta = service.Buscar(id);
                string s = consulta.Status;

                switch (s)
                {
                    case "Confirmado":
                    consulta.Status = "Desmarcado";
                        break;

                    case "Desmarcado":
                        consulta.Status = "Já Chegou";
                        break;

                    case "Já Chegou":
                        consulta.Status = "Em Atendimento";
                        break;

                    case "Em Atendimento":
                        consulta.Status = "Não Confirmado";
                        break;

                    case "Não Confirmado":
                        consulta.Status = "Confirmado";
                        break;

                    default:
                        consulta.Status = "Não Confirmado";
                        break;
                }
                service.Editar(consulta);
                AtualizarAgenda(Convert.ToInt32(CBDentista.SelectedValue));
            }
        }
        private void btnAnotacoes_Click(object sender, EventArgs e)
        {
            Anotacoes frm = new Anotacoes();
            frm.ShowDialog();

            RichTextBox post = new RichTextBox();
            post.ReadOnly = false;
            post.BorderStyle = BorderStyle.None;
            post.Font = new Font(FontFamily.GenericSansSerif, 15F);
            post.ForeColor = Color.FromArgb(64, 64, 64);
            post.Width = 200;
            post.Height = 200;
            post.BackColor = frm.Cor;
            post.Text = frm.Texto;
            Anotacoes.Controls.Add(post); 
        }
        private void CBDentista_Click(object sender, EventArgs e)
        {
            AtualizarCB();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSuporte_Click(object sender, EventArgs e)
        {
            Suporte suporte = new Suporte();
            suporte.ShowDialog();
        }

        private void btnCadastroDentistas_Click(object sender, EventArgs e)
        {
            FrmCadDentista dentista = new FrmCadDentista();
            dentista.ShowDialog();
        }

        private void btnCadastroPacientes_Click(object sender, EventArgs e)
        {
            FrmCadPaciente paciente = new FrmCadPaciente();
            paciente.ShowDialog();
        }

        private void btnCadastroConsultas_Click(object sender, EventArgs e)
        {
            FrmCadConsulta consulta = new FrmCadConsulta();
            consulta.ShowDialog();
        }

        private void btnConsultaDentista_Click(object sender, EventArgs e)
        {
            FrmConsultaDentista consulta = new FrmConsultaDentista();
            consulta.ShowDialog();
        }

        private void btnConsultaPaciente_Click(object sender, EventArgs e)
        {
            FrmConsultaPaciente consulta = new FrmConsultaPaciente();
            consulta.ShowDialog();
        }

        private void btnConsultaGeral_Click(object sender, EventArgs e)
        {
            FrmConsultas consulta = new FrmConsultas();
            consulta.ShowDialog();
        }
    }
}