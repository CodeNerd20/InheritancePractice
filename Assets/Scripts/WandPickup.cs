using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandPickup : Pickup
{
    public GameObject toolPrefab;

    protected override void ActivatePickup()
    {
        ToolControl tc = GameObject.Find("Player").GetComponent<ToolControl>();
        tc.UpdateTool(toolPrefab);
    }
}
