﻿using System;
using System.Collections.Generic;

namespace ProjetNote.Models;

public partial class Donneur
{
    public int IdDonneur { get; set; }

    public string AdresseEmail { get; set; } = null!;

    public string MotDePasse { get; set; } = null!;

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public DateOnly DateDeNaissance { get; set; }

    public string NomComplet
    {
        get
        {
            return Nom + " " + Prenom;
        }
    }

    public virtual ICollection<Questionnaire> Questionnaires { get; set; } = new List<Questionnaire>();
}
