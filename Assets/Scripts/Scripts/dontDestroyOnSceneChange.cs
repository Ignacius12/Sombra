using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroyOnSceneChange : MonoBehaviour
{

    static dontDestroyOnSceneChange instanciaM = null;
    public static dontDestroyOnSceneChange InstanciaMusica
    {
        get { return instanciaM; }
    }


    // Start is called before the first frame update
    void Awake()
    {
        if(instanciaM !=null &&instanciaM != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instanciaM = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
