﻿namespace EcommerceLg.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }

        public UserApplication UserApplication { get; set; }
    }
}
