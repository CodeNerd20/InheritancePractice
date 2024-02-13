using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class DaddyShark : MonoBehaviour
{
    public string sharkName;
    public float swimSpeed;
    public int teeth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Chomp();
        }
    }

    protected virtual void Chomp()
    {
        Debug.Log("CHOMP!");
    }
}
