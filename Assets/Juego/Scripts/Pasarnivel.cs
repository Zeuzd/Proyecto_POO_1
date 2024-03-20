using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pasarnivel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void EsceneCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }
    public void EsceneOpciones()
    {
        SceneManager.LoadScene("Opciones");
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void Inicio()
    {
        SceneManager.LoadScene("Inicio");
    }
}