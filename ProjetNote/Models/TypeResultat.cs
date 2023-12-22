using System;
using System.Collections.Generic;

namespace ProjetNote.Models;

public partial class TypeResultat
{
    public int IdTypeResultat { get; set; }

    public string Statut { get; set; } = null!;

    public virtual ICollection<Questionnaire> Questionnaires { get; set; } = new List<Questionnaire>();
}
