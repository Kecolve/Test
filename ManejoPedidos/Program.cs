using System;

namespace ConsoleApp.ManejoPedidos
{
    public class Personas
    {
        private int id = 0;
        private string nombre = "";
        private string cedula = "";

        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Cedula { get => this.cedula; set => this.cedula = value; }
    }

    public class Paquetes
    {
        private int id = 0;
        private string tipoPaquete = "";
        private string medida = "";

        public int Id { get => this.id; set => this.id = value; }
        public string TipoPaquete { get => this.tipoPaquete; set => this.tipoPaquete = value; }
        public string Medida { get => this.medida; set => this.medida = value; }
    }

    public class Transportistas
    {
        private int id = 0;
        private string tipoTransportista = "";

        public int Id { get => this.id; set => this.id = value; }
        public string TipoTransportista { get => this.tipoTransportista; set => this.tipoTransportista = value; }
    }

    public class Pedidos
    {
        private int id = 0;
        private string codigo = "";
        private List<Detalles> detalles = new List<Detalles>();
        private Personas? persona = null;

        public int Id { get => this.id; set => this.id = value; }
        public string Codigo { get => this.codigo; set => this.codigo = value; }
        public List<Detalles> Detalles { get => this.detalles; set => this.detalles = value; }
        public Personas? Persona { get => this.persona; set => this.persona = value; }
    }

    public class Detalles
    {
        private int id = 0;
        private Paquetes? paquete = null;
        private string descripcion = "";
        private Transportistas? transportista = null;
        private DateTime? fecha = null;
        private string estado = "";

        public int Id { get => this.id; set => this.id = value; }
        public Paquetes? Paquete { get => this.paquete; set => this.paquete = value; }
        public string Descripcion { get => this.descripcion; set => this.descripcion = value; }
        public Transportistas? Transportista { get => this.transportista; set => this.transportista = value; }
        public DateTime? Fecha { get => this.fecha; set => this.fecha = value; }
        public string Estado { get => this.estado; set => this.estado = value; }
    }
}

