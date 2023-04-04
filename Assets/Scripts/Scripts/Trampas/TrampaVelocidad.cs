using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class TrampaVelocidad : Activador
{
    public float modificadorVelocidad = 1f;
    float originalSpeed;
    private Material originalMaterial;
    public GameObject box;
    private Color colorBox;
    public Color ColorDesactivado;
    
    public override void OnHandlePlayerEnter(Jugador jugador)
    {
        originalSpeed = jugador.movimiento.getOriginalSpeed();
          jugador.movimiento.setCurrentSpeed(modificadorVelocidad);
       
    }

    public override void OnHandlePlayerExit(Jugador jugador)
    {
        if (originalSpeed <= 0.0f)
        {
            originalSpeed = jugador.movimiento.getOriginalSpeed();
        }
        jugador.movimiento.setCurrentSpeed(originalSpeed);
    }


    protected override void Start()
    {
        originalMaterial = box.GetComponent<Renderer>().material;
        colorBox = originalMaterial.color;
        base.Start();

    }

    public override void Desactivar()
    {

        base.Desactivar();
        originalMaterial.DOColor(ColorDesactivado, 1f);
    }
    public override void Activar()
    {
        base.Activar();
        originalMaterial.DOColor(colorBox,1f);
    }


}
