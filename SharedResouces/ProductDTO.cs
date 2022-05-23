using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class ProductDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(3, ErrorMessage = "Name Must Be More Than 2 Char")]
        public string Name { get; set; } = "";
        [Required]
        [Range(minimum: 1000, maximum: 10000, ErrorMessage = "Salary between 1000 :10000")]
        public int Price { get; set; } = 0;
        public string Description { get; set; } = "";
        [Required]
        [RegularExpression(@"\w+\.(jpg|png)")]
        public string Image { get; set; } = "";
        [Required]
        public int Cat_Id { get; set; } = 0;
        public string Cat_Name { get; set; } = "";
    }
}
