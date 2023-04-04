using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// VELA MOCTRARRRRRRRRRRRRRRRRRRRRRRRRR

public class InventarioGema
{
    public Text numVelasPosesion; // VELA MOCTRARRRRRRRRRRRRRRRRRRRRRRRRR
    public int gemasRecogidasTotal = 0;
    public int velasDisponibles = 0;
    public int gemasDisponibles = 0;
    public int precioSiguienteVela = 1;
    public string gemasRecogidasId = "";
    //int por el precio de la vela, que a sí mismo la identifica, y bool por si la tiene desbloqueada o no
    // public Dictionary<int, bool> PreciosVelas = 


    //las velas representadas en la mochila en el modelo 3d ingame
    public List<GameObject> velasVisual = new List<GameObject>();




    public void actualizarInventario()
    {

        if (gemasDisponibles == precioSiguienteVela)// == a "i" porque es el precio de la vela xD
        {
            precioSiguienteVela += 1;
            velasDisponibles += 1;
            gemasDisponibles = 0; //se resetean a 0 las gemas que tiene el jugador porque se han gastado.
            //numVelasPosesion.text = velasDisponibles.ToString();//                                                                    VELA MOCTRARRRRRRRRRRRRRRRRRRRRRRRRR

        }
        for (int i = 0; i < velasDisponibles; i++)
        {
            
                velasVisual[i].SetActive(true);
           
               
            
        }
    }
}
