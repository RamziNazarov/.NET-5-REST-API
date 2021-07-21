using System;
using System.Collections.Generic;

namespace REST_API.Entities
{
    public record Category
    {
        //primary key
        public Guid Id { get; init; }
        
        //other columns
        public string Name { get; set; }
        
        //references
        public List<Product> Products { get; set; }
    }
}