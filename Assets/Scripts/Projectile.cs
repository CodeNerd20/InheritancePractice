using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float delay;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, delay); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }
}
