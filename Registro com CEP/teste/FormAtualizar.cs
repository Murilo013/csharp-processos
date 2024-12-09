using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste.Data;
using teste.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace teste
{
    public partial class FormAtualizar : Form
    {
        private readonly AppDbContext _context;
        public FormAtualizar()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var pessoa = await _context.Pessoas.FindAsync(int.Parse(txtId.Text));

                if (pessoa is null)
                {
                    MessageBox.Show($"Id Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtNome.Text = pessoa.Nome;
                    txtTelefone.Text = pessoa.Telefone;
                    txtEmail.Text = pessoa.Email;
                    txtCEP.Text = pessoa.CEP;
                    txtEstado.Text = pessoa.Estado;
                    txtCidade.Text = pessoa.Cidade;
                    txtBairro.Text = pessoa.Bairro;
                    txtRua.Text = pessoa.Rua;
                    txtNumero.Text = pessoa.Numero;
                    txtComplemento.Text = pessoa.Complemento;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Id Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var pessoa = _context.Pessoas.Find(int.Parse(txtId.Text));

            Endereco enderecoValidar = await BuscarCEP(); ;

            if (enderecoValidar.Estado != txtEstado.Text ||
                enderecoValidar.Localidade != txtCidade.Text ||
                enderecoValidar.Bairro != txtBairro.Text ||
                enderecoValidar.Logradouro != txtRua.Text || enderecoValidar is null)
            {
                MessageBox.Show("CEP diferente do buscado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Validando os dados usando data annotations
            var context = new ValidationContext(pessoa, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(pessoa, context, results, true);

            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string telefoneSemMascara = txtTelefone.Text;

            // Valida o telefone usando Regex
            string padraotelefone = @"^\d{2}\d{5}\d{4}$";
            string padraoemail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!isValid)
            {
                foreach (var validationResult in results)
                {
                    MessageBox.Show(validationResult.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!Regex.IsMatch(txtTelefone.Text, padraotelefone))
            {
                MessageBox.Show("Telefone Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(txtEmail.Text, padraoemail))
            {
                MessageBox.Show("Email Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(txtNumero.Text, out int numero))
            {
                MessageBox.Show("Número Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pessoa.Nome = txtNome.Text;
                pessoa.Telefone = txtTelefone.Text;
                pessoa.Email = txtEmail.Text;
                pessoa.CEP = txtCEP.Text;
                pessoa.Estado = txtEstado.Text;
                pessoa.Cidade = txtCidade.Text;
                pessoa.Bairro = txtBairro.Text;
                pessoa.Rua = txtRua.Text;
                pessoa.Numero = txtNumero.Text;
                pessoa.Complemento = txtComplemento.Text;

                await _context.SaveChangesAsync();
                MessageBox.Show("Atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();

            };
        }

        private async Task<Endereco> BuscarCEP()
        {
            try
            {
                // Monta a URL com o CEP informado
                string urlCEP = $"https://viacep.com.br/ws/{txtCEP.Text}/json/";

                // Cria o HttpClient e faz a requisição
                using (HttpClient client = new HttpClient())
                {
                    string dadosJSON = await client.GetStringAsync(urlCEP);

                    // Desserializa o JSON para o objeto Endereco
                    Endereco endereco = JsonConvert.DeserializeObject<Endereco>(dadosJSON);

                    return endereco;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("CEP Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public void Limpar()
        {
            txtTelefone.Clear();
            txtRua.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtComplemento.Clear();
            txtCEP.Clear();
            txtEstado.Clear();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Endereco endereco = await BuscarCEP();

            if (endereco != null)
            {
                txtEstado.Text = endereco.Estado;
                txtCidade.Text = endereco.Localidade;
                txtBairro.Text = endereco.Bairro;
                txtRua.Text = endereco.Logradouro;
                txtCEP.Text = endereco.Cep;
            }
            else
            {
                MessageBox.Show("Não foi possível obter os dados do CEP.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
