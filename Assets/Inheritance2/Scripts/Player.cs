using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : ControllableCreature
{
    /*  protected override void Door()
      {
          if (interactable is PlayerInteractable)
          {
              Debug.Log("Open Door");
              Door.Activate();
          }
      }*/

      protected override void Interact()
    {
        if (interactable is PlayerInteractable)
        {
            Debug.Log("Open Door");
            interactable.Activate();
        }
    }
}
