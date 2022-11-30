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
        yield return new WaitForSeconds(5f);
        AsyncOperation operacion = SceneManager.LoadSceneAsync("Dogs");

        operacion.allowSceneActivation = false;

        while(!operacion.isDone)
        {
            if(operacion.progress >=0.9f)
            {
                operacion.allowSceneActivation = true;
            }
        }
        yield return null;
    }
}
