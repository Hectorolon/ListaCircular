using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCirculares
{
    class Base
    {
        Ruta inicio = null;
        Ruta ultimo = null;

        public void agregar(Ruta nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
                inicio._siguiente = inicio;
                ultimo = inicio;
            }
            else
            {
                ultimo._siguiente = nuevo;
                nuevo._siguiente = inicio;
                ultimo = nuevo;
            }
        }

        public Ruta buscar(string nombre)
        {
            if (inicio != null)
            {
                Ruta t = inicio;
                do
                {
                    if (t._nombre == nombre)
                    {
                        return t;
                    }
                    t = t._siguiente;
                }while (t != inicio) ;
            }
            return null;
        }
        
        public Ruta eliminar(string nombre)
        {
            if (inicio._siguiente != null)
            {
                Ruta t = inicio;
                Ruta anterior = null;
                do
                {
                    if (t._nombre == nombre)
                    {
                        if (t == inicio)
                        {
                            if (inicio._siguiente == inicio)
                                inicio = ultimo = null;
                            else
                            {
                                inicio = inicio._siguiente;
                                ultimo._siguiente = inicio;
                            }
                        }
                        else if (t._siguiente._siguiente == null)
                        {
                            anterior._siguiente = inicio;
                            ultimo = anterior;
                        }
                        else
                            anterior._siguiente = t._siguiente;
                        return t;
                    }
                    anterior = t;
                    t = t._siguiente;
                } while (t != inicio);
            }
            return null;
        }

        public Ruta eliminarInicio()
        {
            Ruta anterior = inicio;
            if (inicio != null)
            {
                inicio = inicio._siguiente;
                ultimo._siguiente = inicio;
            }
            return anterior;
        }

        public Ruta eliminarUltimo()
        {
            
            if (inicio != null)
            {
                Ruta anterior = ultimo;
                if (inicio._siguiente == inicio)
                {
                    inicio = null;
                    ultimo = null;
                }
                else
                {
                    eliminar(ultimo._nombre);
                }
                return anterior;
            }
            return null;
        }

        public string listar()
        {
            string res = "";
            Ruta t = inicio;
            if (inicio != null)
            {
                do
                {
                    res += t.ToString() + Environment.NewLine;
                    t = t._siguiente;
                } while (t != inicio);
            }
            return res;
        }
    }
}
