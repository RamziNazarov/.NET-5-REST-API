using System;

namespace REST_API.Entities
{
    public record Product
    {
        //primary key
        public Guid Id { get; init; }
        
        //other columns
        public string Name { get; set; }
        
        //foreign keys
        public Guid CategoryId { get; set; }
        
        //references
        public Category Category { get; set; }
    }
}