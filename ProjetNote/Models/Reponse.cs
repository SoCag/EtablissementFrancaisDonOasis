using System;
using System.Collections.Generic;

namespace ProjetNote.Models;

public partial class Reponse
{
    public int IdReponse { get; set; }

    public string Reponse1 { get; set; } = null!;

    public virtual ICollection<ReponseQuestionnaire> ReponseQuestionnaires { get; set; } = new List<ReponseQuestionnaire>();
}
