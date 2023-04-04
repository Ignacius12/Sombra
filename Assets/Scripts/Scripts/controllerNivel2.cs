using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerNivel2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("estanGemas contiene: " + guardadoProvisional.estanGemas.Count + " elemenentos;");
        if (guardadoProvisional.estanGemas.Count == 0)
        {
            guardadoProvisional.estanGemas.Add("Gema 1", true);
            guardadoProvisional.estanGemas.Add("Gema 2", true);
            guardadoProvisional.estanGemas.Add("Gema 3", true);
            guardadoProvisional.estanGemas.Add("Gema 4", true);
            guardadoProvisional.estanGemas.Add("Gema 5", true);
            guardadoProvisional.estanGemas.Add("Gema 6", true);
        }
        Debug.Log("estanGemas contiene: " + guardadoProvisional.estanGemas.Count + " elemenentos;");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
