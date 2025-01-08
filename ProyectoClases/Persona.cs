    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ProyectoClases
    {
        public enum TipoGenero { Masculino = 0, Femenino = 1 }
        public enum Paises { España, Francia, Alemania, Andorra, Tabarnia }

        public class Persona
        {

            public Persona()
        {
            this.Nombre = "Anónimo";
            this.Apellidos = "Anónimo";
        }

        public Persona(string nombre, string apellidos)
            {
                this.Nombre = nombre;
                this.Apellidos = apellidos;
            }


        #region PROPIEDADES

        private string _DescripcionThis;
            public string this[int indice]
            {
                get { return this._DescripcionThis; }
                set
                {
                    Random random = new Random();
                    int aleat = random.Next(1, 20);
                    this._DescripcionThis = "Descripción " + aleat;
                }
            }


            public Direccion Domicilio { get; set; }
            public Direccion DomicilioVacaciones { get; set; }



            private TipoGenero _Genero;
            public TipoGenero Genero
            {
                get { return this._Genero; }
                set
                {
                    if (value != TipoGenero.Masculino &&
                        value != TipoGenero.Femenino)
                    {
                        throw new Exception("Valor de género incorrecto");
                    }
                    else
                    {
                        this._Genero = value;
                    }
                }
            }
            public Paises Nacionalidad { get; set; }

            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            //CAMPO PRIVADO PARA LA EDAD
            private int _Edad;
            public int Edad
            {
                get { return this._Edad; }
                set
                {
                    //DEBEMOS COMPROBAR EL VALOR DE LA EDAD
                    //QUE VIENE EN value
                    if (value < 0)
                    {
                        //SI NOS DAN UN VALOR INCORRECTO
                        //ERROR SILENCIOSO
                        //this._Edad = 0;
                        //LANZAMOS UNA EXCEPCION
                        throw new Exception("La edad no puede ser negativa");
                    }
                    else
                    {
                        //TODO CORRECTO
                        this._Edad = value;
                    }
                }
            }
            #endregion

            #region METODOS
            //METODO PARA DEVOLVER UN NOMBRE COMPLETO
            public string GetNombreCompleto()
            {
                return this.Nombre + " " + this.Apellidos;
            }

            //METODO PARA NOMBRE Y APELLIDOS EN MAYUSCULA
            public string GetNombreCompleto(bool mayusculas)
            {
                if (mayusculas == true)
                {
                    return (this.Nombre + " " + this.Apellidos).ToUpper();
                }
                else
                {
                    return (this.Nombre + " " + this.Apellidos).ToLower();
                }
            }


            //METODO PARA DEVOLVER APELLIDOS Y NOMBRE
            public string GetNombreCompleto(int orden)
            {
                return this.Apellidos + " " + this.Nombre;
            }

            public string GetNombreCompleto(int num1, int num2)
            {
                return "";
            }

            public void GetNombreCompleto(string dato) { }

            public void GetNombreCompleto(string dato, int num) { }
            #endregion


        }
    }

