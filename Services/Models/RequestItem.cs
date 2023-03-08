using System.ComponentModel.DataAnnotations;

namespace Services.Models
{
    public class RequestItem<T>
    {
        [Required(ErrorMessage = "Pasar el objeto que se necesita")]
        public T item { get; set; }

        [Required]
        public string token { get; set; }
    }
}
