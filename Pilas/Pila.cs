using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas 
{
    internal class Pila 
    {
        private Nodo cima = null;
        private int contador = 0;
        public void push(string nom) 
        {
            Nodo nuevo = new Nodo();
            nuevo.Nombre=nom;

            nuevo.Sig=cima;
            cima=nuevo;
            contador++;

        }

        public void mostrar(ListBox list) 
        {
            Nodo actual = cima;
            while (actual!=null) 
            {
                list.Items.Add(actual.Nombre);
                actual=actual.Sig;
            }
        }

        public string Pop() 
        {
            if (cima!=null) 
            {
                string nombre = cima.Nombre;
                cima=cima.Sig;
                contador--;
                return nombre;
            }
            return null;
        }
        public int contar() 
        {
            return contador;
        }
        public string Peek() 
        {
            if (cima==null) 
            {
                return cima.Nombre;
            }
            return null;
        }
        public void Clear() 
        {
            cima=null;
            contador=0;
        }
    }
}
