using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// VELA MOCTRARRRRRRRRRRRRRRRRRRRRRRRRR


public class inventarioEstatico : MonoBehaviour
{
    //public Text numVelasPosesion; // VELA MOCTRARRRRRRRRRRRRRRRRRRRRRRRRR
    public int gemasRecogidasTotal = 0;
    public int velasDisponibles = 0;
    public int velasTotales = 0;
    public int gemasDisponibles = 0;
    public int precioSiguienteVela = 1;
    public string gemasRecogidasId = "";
    //las velas representadas en la mochila en el modelo 3d ingame
    //public List<GameObject> velasVisual = new List<GameObject>();


    public static inventarioEstatico IE;

    void Start()
    {
        /*
        if (IE != null)
            GameObject.Destroy(IE);
        else
            IE = this;


        */
       // DontDestroyOnLoad(this);

    }
    
}

