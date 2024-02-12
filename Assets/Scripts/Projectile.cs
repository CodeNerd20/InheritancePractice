using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float duration;


    // Start is called before the first frame update
    protected void Start()
    {
        Destroy(gameObject, duration);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    protected void Move()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
