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
    public partial class FormRemover : Form
    {
        private readonly AppDbContext _context;
        public FormRemover()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var pessoa = await _context.Pessoas.FindAsync(int.Parse(txtIdDelete.Text));

            if (pessoa == null)
            {
                MessageBox.Show($"Id Inexistente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _context.Pessoas.Remove(pessoa);
                _context.SaveChangesAsync();
                MessageBox.Show($"Removido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdDelete.Clear();
            }
        }
    }
}
