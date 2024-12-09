namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormObter formObter = new FormObter();
            formObter.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAtualizar formAtualizar = new FormAtualizar();
            formAtualizar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRemover formRemover = new FormRemover();
            formRemover.ShowDialog();
        }
    }
}
