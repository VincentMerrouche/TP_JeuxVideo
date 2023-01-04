using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Player_controller : MonoBehaviour
{
    // public float speed =0.0f;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public GameObject lostTextObject;
    private Rigidbody rb; //Créer une référence du rigid body a accéder
    // private float mouvementx;
    // private float mouvementy;
    private int compteur;
    public float force;
    bool Lost;


    // Start is called before the first frame update
    void Start()
    {
        //Récupère le RigidBody attaché à la sphère
        rb= GetComponent<Rigidbody>();
        compteur=0;
        SetCountText(); //a besoin d'etre mis a jour
        winTextObject.SetActive(false);
        lostTextObject.SetActive(false);
        Lost =false;
        
    }

    void SetCountText()
    {
        countText.text= "score:" +compteur.ToString();
        if (compteur>=8)
        {
            winTextObject.SetActive(true);
        }
        if (Lost) lostTextObject.SetActive(true);
        
    }

    private void OnTriggerEnter(Collider other)//detecte le contact sans créer de collisions
    {
        if (other.gameObject.CompareTag("PickUp")) 
        {
            other.gameObject.SetActive(false);
            compteur+=1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Lost")) 
        {
            Lost=true;
            SetCountText();
            
        }
        
    }
}



