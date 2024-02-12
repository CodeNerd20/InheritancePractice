using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaNO : No
{
    public string pronouns;

    public void Start()
    {
        Nope();
    }

    public override void Nope()
    {
        Debug.Log("MegaNO");
    }
}
