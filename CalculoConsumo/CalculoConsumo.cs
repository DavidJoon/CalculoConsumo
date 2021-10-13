using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoConsumo
{
    public partial class CalculoConsumo : Form
    {
        public CalculoConsumo()
        {
            InitializeComponent();
        }

        public decimal CalcConsumo(TextBox num)
        {
            try
            {
                return Convert.ToDecimal(num.Text);
            }
            catch
            {
                num.Focus();
                num.SelectAll();
                throw new Exception("Preencha corretamente o campo" + num.Name.ToUpper().Replace("TEXTBOX", ""));
            }
        }
        public void LimparTela()
        {
            foreach(Control ctl in this.Controls)
            {
                if(ctl is TextBox)
                {
                    ctl.Text = string.Empty;
          
                    } else if(ctl is Label && Convert.ToInt32(ctl.Tag).Equals(1)){

                    ctl.Text = string.Empty;
                }
            }
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal KM = CalcConsumo(textBoxKM);
                decimal Litros = CalcConsumo(textBoxLitros);

                decimal Rendimentos = KM/Litros;
                decimal Consumo = Litros/KM ;

                labelRendResul.Text = Rendimentos.ToString("N1");
                labelConsuResul.Text = Consumo.ToString("N3");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção");
            }
        }

        private void CalculoConsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {   
                if(e.KeyChar == 27)
                {
                    LimparTela();
                    textBoxKM.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta");
            }
        }
    }
}
