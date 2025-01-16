using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMan.Models;

    internal class Book
    {
    public int Id { get; set; } //auto-property
    public string Title { get; set; }
    public string Authors { get; set; } 
    public int Year { get; set; }
    public string Genre { get; set; }
    public string Publisher { get; set; }
    public string Isbn { get; set; }
    public string Summary { get; set; }
}

