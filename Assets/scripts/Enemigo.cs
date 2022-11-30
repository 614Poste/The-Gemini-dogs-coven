using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float Velocidad=0;
    private Rigidbody EnemigoRB;
    private GameObject Jugador;
    // Start is called before the first frame update
    void Start()
    {
        EnemigoRB = GetComponent<Rigidbody>();
        Jugador = GameObject.Find("Jugador");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((Jugador.transform.position- transform.position).normalized* Velocidad* Time.deltaTime);
        if(transform.position.y > 1)
        {
          // Destroy(gameObject);
        }
    }
}
