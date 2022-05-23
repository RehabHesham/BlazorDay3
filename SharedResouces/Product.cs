using System.ComponentModel.DataAnnotations.Schema;

namespace SharedModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        //Foriegn key
        [ForeignKey("category")]
        public int Cat_Id { get; set; }

        //Navigation Property
        public Category category { get; set; }
    }
}
