﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BookLeaveDialog : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("(Decided to leave the book where it is)");
        lines.Add("Utter nonsense. I can get by with REAL science, thank you very much.");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}
