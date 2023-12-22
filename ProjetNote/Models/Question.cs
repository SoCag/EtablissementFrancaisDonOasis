using System;
using System.Collections.Generic;

namespace ProjetNote.Models;

public partial class Question
{
    public int IdQuestion { get; set; }

    public int Ordre { get; set; }

    public string Enonce { get; set; } = null!;

    public int IdCategorie { get; set; }

    public virtual Categorie IdCategorieNavigation { get; set; } = null!;

    public virtual ICollection<SousQuestion> SousQuestions { get; set; } = new List<SousQuestion>();
}
