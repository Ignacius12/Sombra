using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    public Movimiento_Jugador movimiento;
    // Start is called before the first frame update
    void Start()
    {
        movimiento = GetComponent<Movimiento_Jugador>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
