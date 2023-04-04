using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botonNivelMenu : MonoBehaviour
{

    public int nivel = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (managerLevels.nievelesBloqueados[nivel - 1]) GetComponent<Button>().interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
