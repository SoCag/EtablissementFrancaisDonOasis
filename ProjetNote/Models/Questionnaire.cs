using System;
using System.Collections.Generic;

namespace ProjetNote.Models;

public partial class Questionnaire
{
    public int IdQuestionnaire { get; set; }

    public string? Complement { get; set; }

    public DateTime DateQuestionnaire { get; set; }

    public bool AccordPartage { get; set; }

    public int IdTypeResultat { get; set; }

    public int IdDonneur { get; set; }

    public virtual Donneur IdDonneurNavigation { get; set; } = null!;

    public virtual TypeResultat IdTypeResultatNavigation { get; set; } = null!;

    public virtual ICollection<ReponseQuestionnaire> ReponseQuestionnaires { get; set; } = new List<ReponseQuestionnaire>();
}
