using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste.Data;
using teste.Models;

namespace teste
{
    public partial class FormObter : Form
    {
        private readonly AppDbContext _context;
        public FormObter()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var pessoas = await _context.Pessoas.ToListAsync();

                DataGridViewPessoas.DataSource = pessoas;
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso ocorra
                MessageBox.Show($"Erro ao buscar os registros: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
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
                    DataGridViewPessoas.DataSource = new List<Pessoa> { pessoa };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Id Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
