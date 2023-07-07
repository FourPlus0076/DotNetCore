using System.ComponentModel.DataAnnotations;

namespace AperioIndia
{
#nullable disable
    public class AdminLogin
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
