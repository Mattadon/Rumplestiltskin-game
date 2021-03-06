﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinalDemonGoodEndDialog : DialogTextController
{
    [SerializeField]
    private Sprite demonIdle;
    [SerializeField]
    private GameObject demon;

    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Really.");
        lines.Add("Disgusting.");
        lines.Add("Yes, You are correct.");
        lines.Add("But that does not matter because");

        this.setLines(lines);
    }

    public override void extraSetup()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonIdle;
    }
}
