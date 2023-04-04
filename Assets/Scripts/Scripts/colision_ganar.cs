using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class colision_ganar : MonoBehaviour
{
    public int nivelColision = 0;

    FSM_Pantalla fSM_Pantalla;
    public GameObject canva;

    // Start is called before the first frame update
    void Start()
    {
        fSM_Pantalla = GetComponent<FSM_Pantalla>();
    }

    //si el tigger observa colision detiene el juego
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Has Ganado");
        Time.timeScale = 0;
        //gameManager.CambiarPausa();//nuevoooooooooooooooooooooooooooooooooo
        canva.SetActive(true);//activar canvas victoria

        //fSM_Pantalla.SetPantallaGanado();

        Invoke("DoSomething", 3);//this will happen after 2 seconds
        
        managerLevels.nievelesBloqueados[nivelColision] = false;
    }
    void DoSomething()
    {
        SceneManager.LoadScene("Menu");
    }

}
