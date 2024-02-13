using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicWandPickup : Pickup
{
    public GameObject toolPrefab;

    protected override void ActivatePickup()
    {
        GameObject.Find("Player").GetComponent<ToolControl>().UpdateTool(toolPrefab);
    }
}
