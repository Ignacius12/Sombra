using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movimiento_Sombra : MonoBehaviour
{
    public Transform objetivo;
    private NavMeshAgent agente;
    public Quaternion angulo;
    public float grado;
    public GameObject procesado;
    public Movimiento_Jugador velocidad;
    public bool latidos = true;

    public GameObject jugador;
    public bool suena = true;

    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();


    }


    // Update is called once per frame
    void Update()
    {
        velocidadInicio();
        var lookPos = objetivo.transform.position - transform.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 1);
        agente.destination = objetivo.position;




        if (Vector3.Distance(transform.position, objetivo.transform.position) < 3 && suena == false)
        {
            procesado.SetActive(true);

            //Debug.Log("LATIDOSSSSSSS...: " + latidos);


        }
        else if (Vector3.Distance(transform.position, objetivo.transform.position) < 3 && suena)
        {
            jugador.GetComponent<AudioSource>().Play();
            suena = false;
        }
        else if (Vector3.Distance(transform.position, objetivo.transform.position) > 3)
        {
            procesado.SetActive(false);
            latidos = false;
            jugador.GetComponent<AudioSource>().Stop();
            suena = true;
        }
    }
    void velocidadInicio()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            agente.speed = velocidad.playerSpeed;
           
        }
    }
}