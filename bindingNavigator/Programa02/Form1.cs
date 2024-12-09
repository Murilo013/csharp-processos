using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDLivrosDataSet.TabLivro' table. You can move, or remove it, as needed.
            this.tabLivroTableAdapter.Fill(this.bDLivrosDataSet.TabLivro);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Salvar o DataTable
            this.Validate();
            this.bindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDLivrosDataSet);
        }
    }
}
