using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsSample : MonoBehaviour
{
   
    int gemas = 0;

    void Start()
    {
        gemas = PlayerPrefs.GetInt("gemas", 0);
        Debug.Log("Gemas cargadas: " + gemas);
    }
   
     
    public void cogeGema()
    {
        gemas++;
        PlayerPrefs.SetInt("puntos", gemas);
        Debug.Log("Puntuación guardada: " + gemas);
    }
}
