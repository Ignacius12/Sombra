using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Activador : MonoBehaviour
{
    protected Collider col;
    public bool estaActivada = true;

    protected virtual void Start()
    {
        col = GetComponent<Collider>();
        if (estaActivada)
        {
            Activar();
        }
        else
        {
            Desactivar();
        }
       
    }
    public void OnTriggerEnter(Collider other)
    {
        if (!estaActivada)
        {
            return;
        }
        Jugador jugador = other.GetComponentInParent<Jugador>();
        if (jugador != null)
        {
            OnHandlePlayerEnter(jugador);
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (!estaActivada)
        {
            return;
        }
        Jugador jugador = other.GetComponentInParent<Jugador>();
        if (jugador != null)
        {
            OnHandlePlayerStay(jugador);
        }

    }
    public void OnTriggerExit(Collider other)
    {
        if (!estaActivada)
        {
            Activar();
        }
        Jugador jugador = other.GetComponentInParent<Jugador>();
        if (jugador != null)
        {
            OnHandlePlayerExit(jugador);
        }
     

    }

    public virtual void OnHandlePlayerEnter(Jugador p) {}
    public virtual void OnHandlePlayerStay(Jugador p) { }
    public virtual void OnHandlePlayerExit(Jugador p) { }
     
    public virtual void Desactivar()
    {
        estaActivada=false;
    }
    public virtual void Activar()
    {
        estaActivada = true;

    }


}
