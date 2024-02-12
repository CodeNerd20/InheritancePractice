using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicWand : Tool
{
    public GameObject projectile;
    public GameObject spawnPoint;

    public override void Activate()
    {
        Instantiate(projectile, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }
}
