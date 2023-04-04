using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{


    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator.GetComponent<Animation>();
    }

    // Update is called once per frame
    public void MostrarVela()
    {
       animator.SetBool("Vela_on", true);
       animator.SetBool("Vela_off", false);


    }

    public void EsconderVela()
    {
        animator.SetBool("Vela_on", false);
        animator.SetBool("Vela_off", true);

    }


}