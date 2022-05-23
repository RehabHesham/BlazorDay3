using System.Collections.Generic;

namespace SharedModels
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation Property
        public List<Product> products { get; set; }
    }
}
