using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida : MonoBehaviour
{
    public static Score instance;
    
 
     private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("hit")){
            
            

            Score.instance.hp();
        }
    }
}
