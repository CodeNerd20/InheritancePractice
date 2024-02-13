using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ControllableCreature : MonoBehaviour
{
    /*
     * This script is meant to be the base class
     * for a controllable creature.
     * 
     * There should be no "Creatures" in the game. 
     * Rather, this should be used as an abstract parent class.
     */

    //Movement
    public float speed;
    private float horizontalInput;

    //Jumping
    protected Rigidbody2D rb;
    public float jumpForce;
    private bool isOnGround;

    //Sprite
    private SpriteRenderer sr;

    //Interactable
    protected Interactable interactable;

    //Controllable
    public bool isControlled;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isControlled)
        {

            //Movement
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector2.right * speed * Time.deltaTime * horizontalInput);
            if(horizontalInput > 0)
            {
                sr.flipX = false;
            }
            if(horizontalInput < 0)
            {
                sr.flipX = true;
            }

            if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
            {
                Jump();
            }

            //Interact
            if(Input.GetKeyDown(KeyCode.E)  && interactable !=null)
            {
                Interact();
            }

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Reset the isOnGround variable
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        //If the object I just triggered has an interactable, save it.
        Interactable newInteraction = collision.gameObject.GetComponent<Interactable>();
        if(newInteraction != null)
        {
            interactable = newInteraction;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Clear the interactable if you are not touching it.
        Interactable exitingInteraction = collision.gameObject.GetComponent<Interactable>();
        if(exitingInteraction == interactable)
        {
            interactable = null;
        }
    }

    protected virtual void Interact()
    {
        
        Debug.Log("I am interacting!");
        interactable.Activate();

    }

    protected virtual void Jump()
    {
            isOnGround = false;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);      
    }
}
