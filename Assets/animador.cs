using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animador : MonoBehaviour
{
    public Animator anim;
    private float InputH;
    private float InputV;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /* if (Input.GetKeyDown("w"))
         {
             anim.Play("Run", -1, 0f);
         }*/
        InputH = Input.GetAxis("Horizontal");
        InputV = Input.GetAxis("Vertical");

        anim.SetFloat("InputH", InputH);
        anim.SetFloat("InputV", InputV);
    }
   
}
