using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Door : PlayerInteractable
{
    /*  protected virtual void Door()
      {
          Destroy(gameObject);
      }*/

    public override void Activate()
    {
        Destroy(gameObject);
    }
}
