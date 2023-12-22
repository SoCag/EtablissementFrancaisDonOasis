using System;
using System.Collections.Generic;

namespace ProjetNote.Models;

public partial class Categorie
{
    public int IdCategorie { get; set; }

    public string Ordre { get; set; } = null!;

    public string Categorie1 { get; set; } = null!;

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public override string ToString()
    {
        return Ordre + " - " + Categorie1;
    }
}
