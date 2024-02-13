using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyShark : DaddyShark
{

    public bool canOpenPDFs = true;

    protected override void Chomp()
    {
        Debug.Log("nom");
    }
}
