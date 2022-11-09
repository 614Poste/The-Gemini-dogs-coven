using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject[] enemigos;
    private float limiteX = 20;
    private float posZ = 20;
    private float start = 2;
    private float delay = 1.5f;
    public Text texto;
    // Start is called before the first frame update
    void Start()
    {
        //Crea pequeñas oleadas de enemigos
        //función,cuantos segundos se va a tardar y el intervalo entre una invocacion y otra
        InvokeRepeating("Desastre", start, delay);
    }

    void Desastre()
    {
        Vector3 posicion = new Vector3(Random.Range(-limiteX, limiteX), 3, posZ);
        int indice = Random.Range(0, enemigos.Length); //.Length mide la cantidad de elementos de un arreglo
        Instantiate(enemigos[indice], posicion, enemigos[indice].transform.rotation);
    }
}
