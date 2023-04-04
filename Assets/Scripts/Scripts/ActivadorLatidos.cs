using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorLatidos : MonoBehaviour
{
    
    public AudioSource quienEmite;
    public Movimiento_Sombra variable;
    public AudioClip mierda;
    public float volume;


    // Update is called once per frame
    void Update()
    {
        if (variable.latidos)
        {
            Debug.Log("La ostia de lo qie sea");
            quienEmite.Play();
            variable.latidos = false;
            
        }
        
    }
}
