using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisSintactico_ReglasSemanticas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            string expresion = txtExpresion.Text;
            AnalizadorSintactico analizador = new AnalizadorSintactico();
            analizador.SetExpresion(expresion);
            string expresionPostfija = analizador.IniciarAnalaisis();

            if (expresionPostfija != "Expresion no valida")
            {
                Resultado.Visible = true;
                Resultado.Text = "Resultado: Válido";
                PilaExpresion.Visible = true;
                PilaExpresion.Text = "Expresion Postfija: " + expresionPostfija;
            }
            else
            {
                Resultado.Visible = true;
                Resultado.Text = "Resultado no valido";
                PilaExpresion.Visible = true;
                PilaExpresion.Text = "Expresion PostFija: No valida";
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtExpresion.Clear();
            Resultado.Text = "";
            Resultado.Visible = false;
            PilaExpresion.Text = "";
            PilaExpresion.Visible = false;
        }
    }
}
