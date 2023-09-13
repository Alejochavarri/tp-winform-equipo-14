using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string linkImagen { get; set; }
        public decimal Precio { get; set; }

        public override string ToString()
        {
            return "ID : " + ID.ToString() + " / " +
                "Codigo : " + Codigo.ToString() + " / " +
                    "Descripcion : " + Descripcion + " / " +
                        "Marca : " + Marca + " / " +
                            "Categoria : " + Categoria + " / " +
                                "Precio : " + Precio.ToString();
        }
    }
}
