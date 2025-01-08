using System.Diagnostics;

namespace ProyectoClases
{
    public enum TipoGenero { Masculino, Femenino, NB};
    public enum Paises { Tailandia, Colombia, Dinamarca, Palestina, Canada };

    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }

        public Direccion()
        {
            Debug.WriteLine("Constructor DIRECCION sin parámetros");
        }

        public Direccion(string calle, string ciudad)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor DIRECCION con dos parámetros");
        }

        public Direccion(string calle, string ciudad, int cp)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = cp;
            Debug.WriteLine("Constructor DIRECCION con tres parámetros");
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido  { get; set; }
        private TipoGenero _Genero { get; set; }
        public Paises Nacionalidad { get; set; }
        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }
        private int _Edad;

        #region METODOS
        public string ObtenerNombreCompleto()
        {
            return this.Nombre + " " + this.Apellido;
        }

        public string ObtenerNombreCompletoDelReves()
        {
            return this.Apellido + " " + this.Nombre;
        }
        #endregion




        public int Edad
        {
            get{ return this._Edad; }
            set
            {
                if (value < 18)
                {
                    throw new Exception("No se permiten menores de edad");
                }
                else
                {
                    this._Edad = value;
                }
            }
        }

        public TipoGenero Genero
        {
            get { return this._Genero; }
            set
            {
                if (value != TipoGenero.NB && value !=TipoGenero.Femenino && value != TipoGenero.Masculino)
                {
                    throw new Exception("Error rancio sry, no sabemos quién es Monique Wittig");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }



    }
}
