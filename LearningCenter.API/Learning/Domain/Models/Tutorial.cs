﻿namespace LearningCenter.API.Learning.Domain.Models;

public class Tutorial
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string description { get; set; }
    public bool Status { get; set; }
    
    // Relationships
    
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}