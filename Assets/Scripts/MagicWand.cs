using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicWand : Tool
{
    public Transform spawner;
    public GameObject projectile;
    private GameManager gm;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    public override void Activate()
    {

        Debug.Log("Magic Wand Activated");
        if (gm.ammo > 0)
        {
            gm.UpdateAmmo(-1);
            Instantiate(projectile, spawner.position, spawner.rotation);
        }
        
    }
}
