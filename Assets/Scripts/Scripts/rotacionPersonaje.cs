using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacionPersonaje : MonoBehaviour
{
    public float rotateSpeed = 90.0F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            
            transform.eulerAngles = new Vector3(0, 90, 0);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            
            transform.eulerAngles = new Vector3(0, -90, 0);
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        /*
        if (Input.GetAxis("Vertical")==0 && Input.GetAxis("Horizontal") == 0)
        {
            Para la animación de estar quieto
        }
        */
    }
}
