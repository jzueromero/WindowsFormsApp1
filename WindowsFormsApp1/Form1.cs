using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Mapeo_Click(object sender, EventArgs e)
        {
            string resultado = null;
            resultado = txtTextoInicial.Text.Replace("{ get; set; }", ",");
            resultado = resultado.Replace("public", "");
            resultado = resultado.TrimStart();
            resultado = resultado.TrimEnd();
            var array = resultado.Split(',');
            string ResutaldoFinal = "";
            int Contador = 0;
            try
            {
                foreach (var i in array)
                {
                    var ParValorString = i.Trim();
                    if (ParValorString.Length > 0)
                    {
                        var Par = ParValorString.Split(' ');
                        ResutaldoFinal += Par[1].ToString() + " = (" + Par[0] + ")item.ItemArray[" + Contador.ToString() + "], \r\n";
                    }
                    Contador++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
            Contador = 0;
            resultado = ResutaldoFinal;
            txtResultado.Text = resultado;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            #region espacios
            string resultado = null;
            resultado = txtTextoInicial.Text.Replace("{ get; set; }", ",");
            resultado = resultado.Replace("public", "");
            resultado = resultado.TrimStart();
            resultado = resultado.TrimEnd();
            var array = resultado.Split(',');
            string ResutaldoFinal = "";
            int Contador = 0;
            #endregion
            try
            {
                foreach (var i in array)
                {
                    var ParValorString = i.Trim();
                    if (ParValorString.Length > 0)
                    {
                        var Par = ParValorString.Split(' ');
                        ResutaldoFinal += string.Format("private {0} _{1}; {2}  public {0} {1} {2} {3} {2} " +
                            "get {2} {3} {2} return _{1}; {4} {2} set {3} _{1} = value; {2} OnPropertyChanged(); " +
                            "{2} {4} {2} {4} ", Par[0].ToString(), Par[1].ToString(), "\r\n", "{", "}");
                    }
                    Contador++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Contador = 0;
            resultado = ResutaldoFinal;
            txtResultado.Text = resultado;
        }
    }
}
