using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelMgr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CargaNivel(string nombrelvl)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(nombrelvl);
    }
    public void CerrarJuego()
    {
        Application.Quit();
    }
}
