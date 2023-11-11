using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public  class Book
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Auther { get; set; }
        public string ImageName { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public bool Publish { get; set; }

        public Guid CatergoryId { get; set; }
        [ForeignKey("CatergoryId")]
        public Category Category { get; set; }
        public Guid SubCatergoryId { get; set; }
        [ForeignKey("SubCatergoryId")]
        public SubCategory SubCategory { get; set; }


        public int CurrentStaut { get; set; }

    }
}
