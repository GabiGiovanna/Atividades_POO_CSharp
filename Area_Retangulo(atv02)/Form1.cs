using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_Retangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Area area = new Area();

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                area.Base = double.Parse(txt_Base.Text);
                area.Altura = double.Parse(txt_Altura.Text);
                area.Calculo();
                MessageBox.Show(area.Retorno());

            }
            catch (FormatException msg)
            {
                MessageBox.Show(msg.Message+"\n Digite um valor númerico válido","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }

        }
    }
}
