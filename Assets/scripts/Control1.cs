using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Control1 : MonoBehaviour
{
    Animator anim;
     public float velocidad = 5;
     public int sens = 30;
    private float ejeX;
    private float ejeY;
    private Rigidbody JugadorRB;
     public GameObject golpe;
     private bool gol;
    private GameObject Camera;

    public float fuerzasalto=10;
    
     

    // Start is called before the first frame update
    void Start()
    {
        JugadorRB = GetComponent<Rigidbody>();
        GameObject.Find("Camera");
        anim =GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento
        ejeX = Input.GetAxis("Horizontal");
       transform.Translate(Vector3.right * Time.deltaTime* velocidad * ejeX);
         ejeY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime*  velocidad * ejeY);
         float horizontalInput = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * sens * horizontalInput * Time.deltaTime);
        gol = Input.GetKeyDown(KeyCode.E);
        
     //Animaciones
        //golpe iniciar
        if(Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("punch",true);
        }
        //golpe fin
      if(Input.GetKeyUp(KeyCode.E))
        {
            anim.SetBool("punch",false);
        }
        //correr
         if(ejeY>=.1)
        {
            anim.SetBool("Run",true);
        }
        if(ejeY<=-.1)
        {
            anim.SetBool("RunA",true);
        }
        if(ejeY==0)
        {
            anim.SetBool("Run",false);
            anim.SetBool("RunA",false);
        }
        //correr fin
       //saltar inicia
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("jump",true);
            //JugadorRB.AddForce(Vector3.up* fuerzasalto,ForceMode.Impulse);
             JugadorRB.AddForce(0,fuerzasalto,0,ForceMode.Impulse);
        }
        if(Input.GetKeyUp(KeyCode.Space)){
            anim.SetBool("jump",false);

        }
       //saltar fin
        //mecanicas
        //golpe
        if(gol)
        {
            //primer parametro asignas el objeto, Segundo parametro la posición de aparición del objeto y tercer parametro crea una copia del objeto
            Instantiate(golpe, transform.position +new Vector3(0,1.5f,0), golpe.transform.rotation);
            
         }
         //vida
         
        
       
    }
    
    }


