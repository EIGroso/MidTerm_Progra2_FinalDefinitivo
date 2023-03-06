using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int monedas = 5;

    public TextMeshProUGUI puntosMoneda;

    private void Update()
    {
        puntosMoneda.text = "LLAVES FALTANTES: " + monedas;

        //if(monedas == 0)
        //{
        //    Salir();
        //}
    }
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    //public void Salir()
    //{
    //    UnityEditor.EditorApplication.isPlaying = false;
    //}
}
