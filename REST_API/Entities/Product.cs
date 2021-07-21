using System;

namespace REST_API.Entities
{
    public record Product
    {
        //primary key
        public Guid Id { get; init; }
        
        //other columns
        public string Name { get; init; }
        
        //foreign keys
        public Guid CategoryId { get; init; }
        
        //references
        public Category Category { get; set; }
    }
}