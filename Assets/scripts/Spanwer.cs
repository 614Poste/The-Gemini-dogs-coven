using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spanwer : MonoBehaviour
{
    public GameObject Enemigos;
    private int contadorEnemigos;
    private int enemigosTotales= 1;
    // Start is called before the first frame update
    void Start()
    {
        
        Spawn(enemigosTotales);
    }

    // Update is called once per frame
    void Update()
    {
        contadorEnemigos = FindObjectsOfType<Enemigo>().Length;
        if(contadorEnemigos == 0) 
        {
            enemigosTotales = enemigosTotales *2;
            Spawn(enemigosTotales);
            
        }
    }

    void Spawn(int cantidad)
    {
    for (int i =0; i< cantidad;i++)
    {
        Instantiate(Enemigos, Posicion() ,Enemigos.transform.rotation);
    }
         
    }
    Vector3 Posicion()
    {
        float PosX = Random.Range(15, 25);
        float PosZ = Random.Range(9, 25);
       return new Vector3(PosX, 4 , PosZ);
        
    }
}
