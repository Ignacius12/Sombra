using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM_Pantalla : MonoBehaviour
{
    Pantalla pantalla;
    // Start is called before the first frame update
    void Start()
    {
        pantalla = GetComponent<Pantalla>();
        pantalla.enabled = false;
    }

    
    public void SetPantallaPerdido()
    {
        pantalla.m_Title = "Has perdido!";
        pantalla.m_Description = "La sombra se ha acercado demasiado a ti...";
        pantalla.enabled = true;
    }

    public void SetPantallaGanado()
    {
        pantalla.m_Title = "Has Ganado!";
        pantalla.m_Description = "Has llegado a la salida sin que la sombra te pille!!";
        pantalla.enabled = true;
    }
    public void SetPantallaTrampa()
    {
        pantalla.m_Title = "Has perdido!";
        pantalla.m_Description = "La trampa te ha matado...";
        pantalla.enabled = true;
    }
}
