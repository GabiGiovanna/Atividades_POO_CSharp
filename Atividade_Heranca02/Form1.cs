using System.Windows.Forms;

namespace Atividade_Heranca02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProjetoPessoa Proj = new ProjetoPessoa();
        private void button1_Click(object sender, System.EventArgs e)
        {

             string nome = (txt_Nome.Text);
           
            string altura = txt_Altura.Text;
            System.DateTime idade = data.Value;
             int dependentes = int.Parse(txt_Dpendentes.Text);

            MessageBox.Show("Seus dados são: "+Proj.Dados(nome, idade, altura));
            MessageBox.Show("Seu plano será no valor de: " + Proj.Plano(dependentes));




        }
    }
}
