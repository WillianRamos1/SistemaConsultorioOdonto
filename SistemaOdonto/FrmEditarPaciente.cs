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
    public partial class FrmEditarPaciente : Form
    {
        public string status;
        Paciente obj = new Paciente();
        PacienteService service = new PacienteService();
        public FrmEditarPaciente(Paciente obj)
        {
            InitializeComponent();
            IniciarFormulario(obj);
        }

        private void IniciarFormulario(Paciente objP)
        {
            this.obj = objP;
            lblCodigo.Text = this.obj.Id.ToString();
            txtNome.Text = this.obj.Nome;
            txtEmail.Text = this.obj.Email;
            txtTelefone.Text = this.obj.Telefone.ToString();
            txtCelular.Text = this.obj.Celular.ToString();
            txtCEP.Text = this.obj.CEP;
            txtEndereco.Text = this.obj.Endereco;
            txtComplemento.Text = this.obj.Complemento;
            CBSexo.Text = this.obj.Sexo;
        }
        private string Validar()
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
                return "Preencha o campo CRO";
            }

            else
            {
                toolStripStatusLabel1.ForeColor = Color.Black;
                return "Sucesso";
            }
        }
            public bool ValidarExclusao()
            {
                DialogResult con = MessageBox.Show("Deseja excluir esse registro ?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (con.ToString().ToUpper() == "YES")
                    return true;
                else return false;
            }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = Validar();
            toolStrip.Text = "";
            if (toolStripStatusLabel1.Text == "Sucesso")
            {
                if (lblCodigo.Text != this.obj.Id.ToString())
                {
                    status = "Apagado";
                    MessageBox.Show("Registro Excluido por outro Usuario !");
                }
                else
                {
                    status = "Editado";
                    this.obj.Nome = txtNome.Text;
                    this.obj.Email = txtEmail.Text;
                    this.obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
                    this.obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
                    this.obj.CEP = txtCEP.Text;
                    service.Editar(this.obj);
                    this.Close();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            toolStrip.Text = "";
            if (ValidarExclusao())
            {
                service.Deletar(this.obj.Id);
                MessageBox.Show("Excluido com Sucesso");
                status = "Apagado";
                this.Close();
            }
        }
    }

    }
