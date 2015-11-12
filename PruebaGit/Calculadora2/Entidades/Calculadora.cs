using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private int numero1;
        private int numero2;
        private int resultado;

        public int Numero1
        {
            get
            {
                return numero1;
            }
            set
            {
                this.numero1 = value;
            }
        }
        public int Numero2 {
            get {
                return this.numero2;
            }
            set {
                this.numero2 = value;
            }
        }

        public int Resultado {
            get {
                return this.resultado;
            }
            set {
                this.resultado = value;
            }
        }
        public Calculadora() { }

        public Calculadora(int p_numero1, int p_numero2, int p_resultado)
        {
            this.numero1 = p_numero1;
            this.numero2 = p_numero2;
            this.resultado = p_resultado;
        }

        public void Sumar(int p_opcion)
        {
            try
            {
                if (p_opcion > 0 && p_opcion < 5)
                {
                    if (p_opcion == 1)
                    {
                        this.resultado = this.numero1 + this.numero2;
                    }
                    else if (p_opcion == 2)
                    {
                        this.resultado = this.numero1 - this.numero2;
                    }
                    else if (p_opcion == 3)
                    {
                        this.resultado = this.numero1 * this.numero2;
                    }
                    else if (p_opcion == 4)
                    {
                        if (this.numero2 != 0)
                        {
                            this.resultado = this.numero1 / this.numero2;
                        }
                        else {
                            throw new Exception("El segundo número no puede ser 0");
                        }
                       
                    }
                }
                else {
                    throw new Exception("La opcion no existe");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.Message);
                //throw;
            }
            
        }
    }
}
