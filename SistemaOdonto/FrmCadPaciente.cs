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
    public partial class FrmCadPaciente : Form
    {
        PacienteService service = new PacienteService();
        public FrmCadPaciente()
        {
            InitializeComponent();
        }

        private string ValidarCad()
        {
            toolStripStatusLabel1.ForeColor = Color.Red;
            if (txtNome.Text == string.Empty)
            {
                return "Preencha o Campo Nome";
            }
            else if (txtCelular.Text == string.Empty)
            {
                return "Preencha o campo Celular";
            }
            else if (txtTelefone.Text == string.Empty)
            {
                return "Preencha o campo Telefone";
            }
            else if (txtEmail.Text == string.Empty)
            {
                return "Preencha o campo E-mail";
            }
            else if (txtCEP.Text == string.Empty)
            {
                return "Preencha o campo CEP";
            }
            else if (txtEndereco.Text == string.Empty)
            {
                return "Preencha o campo Endereço";
            }
            else if (txtComplemento.Text == string.Empty)
            {
                return "Preencha o campo Complemento";
            }
            else if (DateTimeNascimento.Text == string.Empty)
            {
                return "Preencha o campo Data de Nascimento";
            }
            else if (CBSexo.Text == string.Empty)
            {
                return "Preencha o campo Sexo";
            }

            else
            {
                toolStripStatusLabel1.ForeColor = Color.Black;
                return "Sucesso";
            }
        }

        public Paciente objGerado()
        {
            Paciente obj = new Paciente();
            obj.Nome = txtNome.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
            obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
            obj.CEP = txtCEP.Text;
            obj.Endereco = txtEndereco.Text;
            obj.Complemento = txtComplemento.Text;
            obj.Nascimento = Convert.ToDateTime(DateTimeNascimento.Value);
            obj.Sexo = CBSexo.Text;
            return obj;
        }

        public void Limpar()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtCEP.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtCelular.Text = string.Empty;
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
                    MessageBox.Show("Cadastro Efetuado com Sucesso");
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar" + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FrmConsultaPaciente frm = new FrmConsultaPaciente();
            frm.ShowDialog();
        }
    }
    }
