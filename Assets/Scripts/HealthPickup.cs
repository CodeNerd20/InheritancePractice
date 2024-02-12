using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Pickup
{
    public int healthValue;

    protected override void ActivatePickup()
    {
        base.ActivatePickup();
        gm.UpdateHealth(healthValue);
    }
}
