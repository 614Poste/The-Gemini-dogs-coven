using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    private float cont = 0;
    private int est = 0;
    public int HP=50;
    public TMP_Text kills;
    public TMP_Text estrellas;
    public TMP_Text vida;
  
   private int hptotal;
    
    public static Score instance;
     


    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    
    void Start()
    {
        //encuentra el objeto por medio de el ID
        kills.text = cont.ToString() + " Kills";
        estrellas.text = cont.ToString() + " Estrellas";
        vida.text = HP.ToString()+" de " + HP.ToString();
        hptotal=HP;

    }

    public void kill()
    {
        cont = cont + 1;
        kills.text = cont.ToString() + " kills";
    }
     public void estre()
    {
        est = est + 1;
        estrellas.text = est.ToString() + " estrellas";
        if(est ==8)
        {
            estrellas.text =  " Mision completa, Ve con hecate";
             StartCoroutine(Reset());
            
        }
    }
    public void hp()
    {
        
        HP = HP -1;
        vida.text = HP.ToString() +" / " + hptotal.ToString();
        if(HP<=0)
        {
            StartCoroutine(Dead());
        }
    }
   IEnumerator Reset ()
    {
        yield return new WaitForSeconds(2f);
       SceneManager.LoadScene("Menu");

        yield return null;
    }
    IEnumerator Dead ()
    {
        
       SceneManager.LoadScene("Menu");

        yield return null;
    }
  
}
