using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class TrampaDaño : Activador
{
    //public FSM_Pantalla fSM_Pantalla;
    public GameObject canva;
    private Vector3 originalPosition;
    protected override void Start()
    {
        originalPosition = transform.position;
        base.Start();
    }
    public override void OnHandlePlayerEnter(Jugador p)
    {
        Debug.Log("Fin del juego");
        Time.timeScale = 0;
        canva.SetActive(true);//activar canvas victoria

        //fSM_Pantalla.SetPantallaTrampa();
    
    }

    public override void OnHandlePlayerExit(Jugador p)
    {
    }



    public override void Desactivar()
    {

        base.Desactivar();
        transform.DOMoveY(originalPosition.y - 1.0f, 1f, false);
    }
    public override void Activar()
    {
        base.Activar();
        transform.DOMoveY(originalPosition.y, 1f,false);
    }




}
