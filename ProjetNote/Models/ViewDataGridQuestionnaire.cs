using System;
using System.Collections.Generic;

namespace ProjetNote.Models;

public partial class ViewDataGridQuestionnaire
{
    public int IdQuestionnaire { get; set; }

    public string Question { get; set; } = null!;

    public string Reponse { get; set; } = null!;

    public string? Complement { get; set; }

    public int RendImpossible { get; set; }
}
