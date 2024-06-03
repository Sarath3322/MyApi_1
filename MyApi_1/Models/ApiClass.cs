using System.ComponentModel.DataAnnotations;

namespace MyApi_1.Models
{
    public class ApiClass
    {
    
      public int Id { get; set; }
        public required string Name { get; set; }
        public required string Division{ get; set; }
        public int age {  get; set; }

    }
}
