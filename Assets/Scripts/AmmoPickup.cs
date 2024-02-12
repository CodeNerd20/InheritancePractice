using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : Pickup
{
    public int ammoValue;



    protected override void ActivatePickup()
    {
        base.ActivatePickup();
        gm.UpdateAmmo(ammoValue);
    }
}
