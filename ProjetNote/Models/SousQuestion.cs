using System;
using System.Collections.Generic;

namespace ProjetNote.Models;

public partial class SousQuestion
{
    public int IdSousQuestion { get; set; }

    public string Ordre { get; set; } = null!;

    public bool NecessiteComplement { get; set; }

    public bool RendImpossible { get; set; }

    public string Enonce { get; set; } = null!;

    public int IdQuestion { get; set; }

    public virtual Question IdQuestionNavigation { get; set; } = null!;

    public virtual ICollection<ReponseQuestionnaire> ReponseQuestionnaires { get; set; } = new List<ReponseQuestionnaire>();
}
