using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TrampaDesactivar : Activador
{
    public float activationTime = 0.5f;
    private float timer = 0.0f;
    private bool timerCompleted = false;
    
    public override void OnHandlePlayerEnter(Jugador jugador)
    {
        prueba();
        timer = Time.time + activationTime;
        
    }

    public override void OnHandlePlayerStay(Jugador jugador)
    {
        if(Time.time >= timer && !timerCompleted )
        {
            OntimerCompleted();
            timerCompleted = true;
                
        }
       


    }

    public override void OnHandlePlayerExit(Jugador jugador)
    {
        prueba();
        timerCompleted = false;
        timer = 0.0f;
      
        

    }

    public void OntimerCompleted()
    {
        Activador[] activadores = FindObjectsOfType<Activador>();
        for (int i = 0; i < activadores.Length; i++)
        {
            activadores[i].Desactivar();
           
        }
        
    }

    public void prueba()
    {
        Activador[] activadores = FindObjectsOfType<Activador>();
        for (int i = 0; i < activadores.Length; i++)
        {
            activadores[i].Activar();

        }

    }


    public override void Desactivar()
    {
        base.Desactivar();
    }
    public override void Activar()
    {
        base.Activar();

    }


}
