namespace ImpressaoZebra
{
    public partial class Form1 : Form
    {
        EtiquetaquimioController etiqueta = new EtiquetaquimioController();
        List<string> dados = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbmatpes.Text))
            {
                MessageBox.Show("Preencha a matrícula!");
            }
            else
            {
                dados = etiqueta.BuscaDados(tbmatpes.Text);
                if (dados != null && dados.Count > 1)
                {
                    // MessageBox.Show(dados[1]);
                    nmpaciente.Text = dados[0];
                    nmmae.Text = dados[1];
                    matricula.Text = dados[2];
                    dtnasc.Text = dados[3];
                }
                else MessageBox.Show("Retorno nulo!");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listar impressoras no dropdown
            listimpressoras.Items.Clear();

            foreach (var printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                listimpressoras.Items.Add(printer);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dados.Clear();
            dados.Add(nmpaciente.Text);
            dados.Add(nmmae.Text);
            dados.Add(matricula.Text);
            dados.Add(dtnasc.Text);
            dados.Add(composicao.Text);
            dados.Add(vazao.Text);
            dados.Add(data.Text);
            dados.Add(hora.Text);
            dados.Add(protocolo.Text);
            dados.Add(solucao.Text);
            etiqueta.ImprimirDados(dados, listimpressoras.SelectedItem.ToString());
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}