using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class SubCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid CatergoryId { get; set; }
        [ForeignKey("CatergoryId")]
        public Category Category { get; set; }

        public int CurrentStaut { get; set; }

    }
}
