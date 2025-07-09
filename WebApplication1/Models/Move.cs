﻿using WebApplication1.Models;

public class Move
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public int Power { get; set; }
    public int Accuracy { get; set; }
    public Pokemon Pokemon { get; set; }  
}
