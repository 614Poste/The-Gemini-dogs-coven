using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adelante : MonoBehaviour
{
    public int velocidad = 5;
    public float totaltime;
    private float reset;
    private float seg;
    private float segn;
    private float tiempoene = 1;
    private float stringTime;

    
    void Start()
    {
        
        stringTime = totaltime;
    }
    // Update is called once per frame
    void Update()
    {
        
        reset = totaltime;
        transform.Translate(transform.position);
        totaltime -= Time.deltaTime;
        seg = (int) (totaltime %60);
        if(seg ==0)
        {
            Destroy(gameObject);
            
            totaltime = reset;
             tiempoene = 3;
        }
    }

    //captura el collider del objeto que acaba de entrar
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigos")){
            
            Destroy(gameObject);
        Destroy(other.gameObject);
        Score.instance.kill();
        }
        
        
    }
}
