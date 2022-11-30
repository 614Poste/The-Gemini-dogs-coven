using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Cargando : MonoBehaviour
{
    
   private void Start()
    {
        
        StartCoroutine(IniciarCargar());
    }
    IEnumerator IniciarCargar ()
    {
        yield return new WaitForSeconds(10f);
       SceneManager.LoadScene("Dogs");

        

        
        yield return null;
    }
}
