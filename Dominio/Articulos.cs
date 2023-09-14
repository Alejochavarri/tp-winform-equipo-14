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
        public string Codigo { get; set; }
        public decimal Precio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public List<Imagen> Imagen { get; set; }
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
