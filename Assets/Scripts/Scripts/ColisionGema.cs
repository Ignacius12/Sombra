using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;// VELA MOCTRARRRRRRRRRRRRRRRRRRRRRRRRR
using UnityEngine.SceneManagement;

public class ColisionGema : MonoBehaviour
{
    public Text numVelasPosesion; // VELA MOCTRARRRRRRRRRRRRRRRRRRRRRRRRR
    public int idGema;
    inventarioEstatico inventario;
    DataSaveLoad saveLoad;
    const string KEYNAME = "inventarioGema";
    Vela velaPlayer;
    List<string> listaGemasId;
    List<GameObject> listaGemasEscena;
    public GameObject pulsaE;
    public AudioSource quienEmite;
    public Text numGemasPosesion;

    // Start is called before the first frame update
    void Start()
    {
        if (quienEmite!=null||numVelasPosesion!=null)
        {
            inventario = GameObject.FindGameObjectWithTag("INVENTARIO").GetComponent<inventarioEstatico>();
            velaPlayer = GameObject.FindGameObjectWithTag("Sombra").GetComponent<Vela>();

            saveLoad = new DataSaveLoad();
            //POR SI SE RALLA
            //saveLoad.Clear(KEYNAME);// BORRRRRRRRRRRRRRRRRRAAAAAAAAAAAAAAARRRRRRRRRRR PARTIDA


            saveLoad.Load(KEYNAME, ref inventario);
            inventario.velasDisponibles = inventario.velasTotales;
            listaGemasId = inventario.gemasRecogidasId.Split(',').ToList();
            listaGemasEscena = GameObject.FindGameObjectsWithTag("Gema").ToList();
            int veces = 1;
            for (int i = 0; i < listaGemasId.Count; i++)
            {

                if (("Gema " + gameObject.GetComponent<ColisionGema>().idGema) == listaGemasId[i])
                {
                    gameObject.SetActive(false);
                    Debug.Log("Vez que entra: " + veces);
                    veces += 1;
                }

            }
            numVelasPosesion.text = inventario.velasDisponibles.ToString();
            numGemasPosesion.text = inventario.gemasDisponibles.ToString();
        }
        else
        {
            


        }



    }

    private void Update()
    {

        if (quienEmite != null || numVelasPosesion != null)
        {
            transform.Rotate(0f, 0f, 60f * Time.deltaTime);
           // numVelasPosesion.text = inventario.velasDisponibles.ToString();
            //numGemasPosesion.text = inventario.gemasDisponibles.ToString();

          
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
            Debug.Log("Holaaaaaaaaaaaaaaaaaa");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            inventario = GameObject.FindGameObjectWithTag("INVENTARIO").GetComponent<inventarioEstatico>();
            velaPlayer = GameObject.FindGameObjectWithTag("Sombra").GetComponent<Vela>();
            saveLoad = new DataSaveLoad();
          

            //POR SI SE RALLA
            saveLoad.Clear(KEYNAME);// BORRRRRRRRRRRRRRRRRRAAAAAAAAAAAAAAARRRRRRRRRRR PARTIDA

            Debug.Log("PARTIDA BORRADAAAAAAAAA");
            saveLoad.Load(KEYNAME, ref inventario);
            inventario.velasDisponibles = inventario.velasTotales;
            listaGemasId = inventario.gemasRecogidasId.Split(',').ToList();
            listaGemasEscena = GameObject.FindGameObjectsWithTag("Gema").ToList();
            int veces = 1;
            for (int i = 0; i < listaGemasId.Count; i++)
            {

                if (("Gema " + gameObject.GetComponent<ColisionGema>().idGema) == listaGemasId[i])
                {
                    gameObject.SetActive(false);
                    Debug.Log("Vez que entra: " + veces);
                    veces += 1;
                }

            }
            //numVelasPosesion.text = inventario.velasDisponibles.ToString();
            //numGemasPosesion.text = inventario.gemasDisponibles.ToString();
        }

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            //quienEmite.Play();
            Debug.Log("wiwiwiwuwiuwiwuiwuiwuiw" + "Gema " + listaGemasEscena[0].GetComponent<ColisionGema>().idGema);
            inventario.gemasRecogidasTotal += 1;
            inventario.gemasDisponibles += 1;
            //inventario.velasDisponibles += 1;
            inventario.gemasRecogidasId += "Gema " + idGema + ",";

            //Debug.Log("wiwiwiwuwiuwiwuiwuiwuiw" + inventario.velasVisual.Length);
            actualizarInventario();
            Debug.Log("GEMASRecogidasTotaal" + inventario.gemasRecogidasTotal);
            Debug.Log("PRECIOSVELAS" + inventario.precioSiguienteVela);
            Debug.Log("DISPONIBLEESVelas" + inventario.velasDisponibles);
            Debug.Log("GEMAS_DISPONIBLEES" + inventario.gemasDisponibles);
            Debug.Log("VELAS_TOTALEEES" + inventario.velasTotales);
            numVelasPosesion.text =  inventario.velasDisponibles.ToString();
            numGemasPosesion.text =  inventario.gemasDisponibles.ToString();
            saveLoad.Save(KEYNAME, inventario);
            velaPlayer.actualizarVelaInventario();

            gameObject.SetActive(false);

            pulsaE.SetActive(true);
            //velaPlayer.actualizarVelaInventario();


        }


    }

    /*public void rellenarListaVisual()
    {
        inventario.velasVisual.Add(GameObject.FindGameObjectWithTag("velaBolsa1"));
        inventario.velasVisual.Add(GameObject.FindGameObjectWithTag("velaBolsa2"));
        inventario.velasVisual.Add(GameObject.FindGameObjectWithTag("velaBolsa3"));
        inventario.velasVisual.Add(GameObject.FindGameObjectWithTag("velaBolsa4"));
        inventario.velasVisual.Add(GameObject.FindGameObjectWithTag("velaBolsa5"));
    }*/
    public void actualizarInventario()
    {

        if (inventario.gemasDisponibles == inventario.precioSiguienteVela)// == a "i" porque es el precio de la vela xD
        {
            inventario.precioSiguienteVela += 1;
            inventario.velasTotales += 1;
            inventario.velasDisponibles += 1;
            inventario.gemasDisponibles = 0; //se resetean a 0 las gemas que tiene el jugador porque se han gastado.
            //numVelasPosesion.text = velasDisponibles.ToString();//                                                                    VELA MOCTRARRRRRRRRRRRRRRRRRRRRRRRRR

        }
        /*for (int i = 0; i < inventario.velasDisponibles; i++)
        {

            inventario.velasVisual[i].SetActive(true);



        }*/
    }
    public void BorrarPartida()
    {
        saveLoad.Clear(KEYNAME);// BORRRRRRRRRRRRRRRRRRAAAAAAAAAAAAAAARRRRRRRRRRR PARTIDA
       
          
        Time.timeScale = 1f;
        Debug.Log("Partida Borrada");

    }
}
