using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisSintactico_ReglasSemanticas
{
    internal class AnalizadorSintactico
    {
        //Declaramos las propiedades de nuestra clase
        private string expresion;
        private int posicionActual;
        private bool expresionValida;
        private List<string> pilaOperadores;
        private string resultado;

        //Nuestro constructor de la clase AnalizadorSintactico.
        public AnalizadorSintactico()
        {
            expresion = string.Empty;
            posicionActual = 0;
            expresionValida = true;
            resultado = string.Empty;
            pilaOperadores = new List<string>();
        }

        //Seteamos la expresión que nos pasará el usuario.
        public void SetExpresion(string expresion)
        {
            this.expresion = expresion;
        }
        //Verificamos si es un dígito.
        public bool EsDigito(char caracter)
        {
            return char.IsDigit(caracter);
        }
        //Procesamos la expresión.
        public void ProcesarExpresion()
        {
            Expresion();
            resultado = expresionValida ? string.Join(" ", pilaOperadores) : "No valida";
        }
        //Coincidomos.
        private void Coincidir(char caracter)
        {
            if (posicionActual < expresion.Length && expresion[posicionActual] == caracter)
            {
                posicionActual++;
            }
            else
            {
                expresionValida = false;
            }
        }
        //Pasamos la expresion.
        private void Expresion()
        {
            Termino();
            while(posicionActual < expresion.Length && (expresion[posicionActual] == '+' || expresion[posicionActual] == '-'))
            {
                char operador = expresion[posicionActual];
                posicionActual++;
                Termino();
                pilaOperadores.Add(operador.ToString());
            }
        }

        private void Termino()
        {
            Factor();
            while(posicionActual < expresion.Length && (expresion[posicionActual] == '*' || expresion[posicionActual] == '/'))
            {
                char operador = expresion[posicionActual];
                posicionActual++;
                Factor();
                pilaOperadores.Add(operador.ToString());
            }
        }

        private void Factor()
        {
            if(posicionActual < expresion.Length)
            {
                if (EsDigito(expresion[posicionActual]))
                {
                    int inicioNumero = posicionActual;
                    while(posicionActual < expresion.Length && EsDigito(expresion[posicionActual]))
                    {
                        posicionActual++;
                    }
                    pilaOperadores.Add(expresion.Substring(inicioNumero, posicionActual - inicioNumero));
                }
                else if (expresion[posicionActual] == '(')
                {
                    posicionActual++;
                    Expresion();
                    if(posicionActual < expresion.Length && expresion[posicionActual] == ')')
                    {
                        Coincidir(')');
                    }
                    else
                    {
                        expresionValida = false;
                    }
                }
                else
                {
                    expresionValida = false;
                }
            }
            else
            {
                expresionValida = false;
            }
        }
        //Obtenemos la expresion post fija.
        public string ObtenerExpresionPostFija()
        {
            return resultado;
        }

        public string IniciarAnalaisis()
        {
            ProcesarExpresion();
            return expresionValida ? ObtenerExpresionPostFija() : "Expresion no valida";
        }
    }
}
