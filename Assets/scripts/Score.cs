using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private float cont = 0;
    private int est = 0;
    public int HP=10;
    public TMP_Text kills;
    public TMP_Text estrellas;
    public TMP_Text vida;
   public vida h;
   
    
    public static Score instance;
      private int hptotal;


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
        h = FindObjectOfType<vida>();
        vida.text = HP.ToString()+" / " + h.ToString();
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
        }
    }
    public void hp()
    {
        
        HP = HP -1;
        vida.text = HP.ToString() +" / " + hptotal.ToString();
    }
  
}
