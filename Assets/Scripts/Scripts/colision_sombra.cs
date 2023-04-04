using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision_sombra : MonoBehaviour
{

    FSM_Pantalla fSM_Pantalla;
    public GameObject canva;
    public bool prueba = false;
    public Animator anim;
    public GameObject jugador;
    public AudioSource quienEmite;
    

    void Start()
    {
        fSM_Pantalla = GetComponent<FSM_Pantalla>();
    }

    //si el tigger observa colision detiene el juego
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            /*anim.Play("Muerte", -1, 0f);*/
            anim.SetTrigger("Muerte");
            jugador.GetComponent<Movimiento_Jugador>().enabled = false;
            StartCoroutine("Fade");
            prueba = true;
            quienEmite.Play();
        }
    }

    IEnumerator Fade()
    {
        yield return new WaitForSeconds(2f);

        Debug.Log("Fin del juego");
        Time.timeScale = 0;
        canva.SetActive(true);//activar canvas derrota


    }



}
