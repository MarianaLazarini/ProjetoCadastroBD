using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace ProjetoCadastroBD
{
    public partial class TelaAluno : MaterialForm
    {
        bool isAlteracao = false;
        string conexao = @"server=127.0.0.1;" +
                          "uid=root;" +
                          "pwd=Mari040304*" +
                          "database=academico;";

        public object TabPageCadastro { get; private set; }

        public TelaAluno()
        {
            InitializeComponent();
        }
        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("Matr�cula obrig�toria!", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome obrig�torio!", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Endere�o obrig�torio!", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Cidade obrig�toria!", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("Bairro obrig�toria!", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
                return false;
            }

            if (!DateTime.TryParse(txtNascimento.Text, out DateTime _))
            {
                MessageBox.Show("Nascimento obrig�torio!", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNascimento.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Senha obrig�toria!", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return false;
            }

            return true;
        }

        private void LimparCampos()
        {
            isAlteracao = false;
            foreach (var control in TabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }
    }
}
