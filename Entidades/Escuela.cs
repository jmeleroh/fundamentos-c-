namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int AñoCreacion{ get;set;}

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela{ get;set;}

        // Constructor
        // Un constructor es un método cuyo nombre es igual que el nombre de su tipo

        /*public Escuela(string nombre, int año)
        {
            this.nombre = nombre;
            this.AñoCreacion = año;
        }*/
        
        public Escuela(string nombre, int año) => (Nombre,AñoCreacion) = (nombre,año);

        //Si le asignamos un valor a un parámetro del método, C# lo considerará como opcional
        public Escuela(string nombre, int año, TiposEscuela tipos, string pais="", string ciudad="")
        {
            (Nombre,AñoCreacion) = (nombre,año);
            Pais = pais;
            this.Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela} \n País: {Pais}, Ciudad: {Ciudad}";
        }
    }
}