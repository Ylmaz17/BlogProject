using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class City
    {
        [Key]
        public Int16 CityId { get; set; }
        public string CityName { get; set; }
        public List<Writer> Writers { get; set; }
    }
}
