using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreAndFood.Data.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage ="Kategori adı boş geçilemez")]
        [StringLength(20,ErrorMessage ="Lütfen 4 ile 20 karakter uzunluğunda değer giriniz",MinimumLength =4)]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool Status { get; set; }
        public List<Food> Foods { get; set; }
        
    }
}
