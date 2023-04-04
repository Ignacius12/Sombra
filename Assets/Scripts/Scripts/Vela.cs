using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vela : MonoBehaviour
{
    // Start is called before the first frame update
    public Personaje personaje;
    inventarioEstatico inventario;
    public Collider colider;
    public float time = 5f;
    float _time;
    bool velaActiva = false;
    // InventarioGema inventario;
    DataSaveLoad dataSaveLoad;
    public GameObject velaJuego;
    const string KEYNAME = "inventarioGema";
    public GameObject pulsaE2;

    void Start()
    {

        inventario = GameObject.FindGameObjectWithTag("INVENTARIO").GetComponent<inventarioEstatico>();
        dataSaveLoad = new DataSaveLoad();
        dataSaveLoad.Load(KEYNAME, ref inventario);
        _time = time;
        colider = GetComponent<Collider>();
        colider.enabled = true;
    }
    public void actualizarVelaInventario()
    {
        dataSaveLoad.Load(KEYNAME, ref inventario);
    }
    // Update is called once per frame
    void Update()
    {
        //Cuando pulsamos la e se activa un flag
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (inventario.velasDisponibles > 0)
            {
                personaje.MostrarVela();

                velaActiva = true;
                Debug.Log("inicio vela");
                velaJuego.SetActive(true);//APARECER VELA EN CUERPO
                inventario.velasDisponibles -= 1;
                //actualizarInventario();
                pulsaE2.SetActive(false);
                Debug.Log("GEMASRecogidasTotaal" + inventario.gemasRecogidasTotal);
                Debug.Log("PRECIOSVELAS" + inventario.precioSiguienteVela);
                Debug.Log("DISPONIBLEESVelas" + inventario.velasDisponibles);
                Debug.Log("GEMAS_DISPONIBLEES" + inventario.gemasDisponibles);
                Debug.Log("VELAS_TOTALEEES" + inventario.velasTotales);

            }
        }

        //va revisando el tiempo que queda y cuando es 0 desactiva el flag
        if (velaActiva)
        {
            colider.enabled = false;
            _time -= Time.deltaTime;

            if (_time <= 0)
            {
                personaje.EsconderVela();

                Debug.Log("fin vela");
                colider.enabled = true;
                velaActiva = false;
                _time = time;
                velaJuego.SetActive(false);//DESAPARECER VELA EN CUERPO

            }
        }

    }
    public void actualizarInventario()
    {

        if (inventario.gemasDisponibles == inventario.precioSiguienteVela)// == a "i" porque es el precio de la vela xD
        {
            inventario.precioSiguienteVela += 1;
            inventario.velasDisponibles += 1;
            inventario.gemasDisponibles = 0; //se resetean a 0 las gemas que tiene el jugador porque se han gastado.
            //numVelasPosesion.text = velasDisponibles.ToString();//                                                                    VELA MOCTRARRRRRRRRRRRRRRRRRRRRRRRRR

        }
        /* for (int i = 0; i<inventario.velasVisual.Count ; i++)
         {
             if ((i + 1) < inventario.velasDisponibles)
             {
                 inventario.velasVisual[i].SetActive(true);

             }
             else
             {
                 inventario.velasVisual[i].SetActive(false);
             }
         }*/
    }

}


/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vela : MonoBehaviour
{
    // Start is called before the first frame update
    public Personaje personaje;
    inventarioEstatico inventario;
    public Collider colider;
    public float time = 5f;
    float _time;
    bool velaActiva = false;
   // InventarioGema inventario;
    DataSaveLoad dataSaveLoad;
    public GameObject velaJuego;
    const string KEYNAME = "inventarioGema";
    public GameObject pulsaE2;

    void Start()
    {

        inventario = GameObject.FindGameObjectWithTag("INVENTARIO").GetComponent<inventarioEstatico>();
        dataSaveLoad = new DataSaveLoad();
        dataSaveLoad.Load(KEYNAME, ref inventario);
        _time = time;
        colider = GetComponent<Collider>();
        colider.enabled = true;
    }
    public void actualizarVelaInventario()
    {
        dataSaveLoad.Load(KEYNAME, ref inventario);
    }
    // Update is called once per frame
    void Update()
    {
        //Cuando pulsamos la e se activa un flag
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (inventario.velasDisponibles > 0)
            {
                personaje.MostrarVela();

                velaActiva = true;
                Debug.Log("inicio vela");
                //velaJuego.SetActive(true);//APARECER VELA EN CUERPO
                inventario.velasDisponibles -= 1;
                actualizarInventario();
                pulsaE2.SetActive(false);


            }
        }

        //va revisando el tiempo que queda y cuando es 0 desactiva el flag
        if (velaActiva)
        {
            colider.enabled = false;
            _time -= Time.deltaTime;

            if (_time <= 0)
            {
                personaje.EsconderVela();

                Debug.Log("fin vela");
                colider.enabled = true;
                velaActiva = false;
                _time = time;
                velaJuego.SetActive(false);//DESAPARECER VELA EN CUERPO

            }
        }

    }
    public void actualizarInventario()
    {

        if (inventario.gemasDisponibles == inventario.precioSiguienteVela)// == a "i" porque es el precio de la vela xD
        {
            inventario.precioSiguienteVela += 1;
            inventario.velasDisponibles += 1;
            inventario.gemasDisponibles = 0; //se resetean a 0 las gemas que tiene el jugador porque se han gastado.
            //numVelasPosesion.text = velasDisponibles.ToString();//                                                                    VELA MOCTRARRRRRRRRRRRRRRRRRRRRRRRRR

        }
       
    }

}
*/