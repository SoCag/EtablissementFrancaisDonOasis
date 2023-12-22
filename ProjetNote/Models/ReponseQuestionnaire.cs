using System;
using System.Collections.Generic;

namespace ProjetNote.Models;

public partial class ReponseQuestionnaire
{
    public int IdReponseQuestionnaire { get; set; }

    public int IdSousQuestion { get; set; }

    public int IdQuestionnaire { get; set; }

    public int IdReponse { get; set; }

    public virtual Questionnaire IdQuestionnaireNavigation { get; set; } = null!;

    public virtual Reponse IdReponseNavigation { get; set; } = null!;

    public virtual SousQuestion IdSousQuestionNavigation { get; set; } = null!;
}
