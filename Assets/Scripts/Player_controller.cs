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
    private Rigidbody rb; //Créer une référence du rigid body a accéder
    // private float mouvementx;
    // private float mouvementy;
    private int compteur;
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        //Récupère le RigidBody attaché à la sphère
        rb= GetComponent<Rigidbody>();
        compteur=0;
        SetCountText(); //a besoin d'etre mis a jour
        winTextObject.SetActive(false);
    }

// //OnMove -> fonction de InputSystem de Unity
//     void OnMove(InputValue mouvementValue)
//     {
//         //movement vector = prend le movement valeur déplacement sphère
//         Vector2 mouvementVector =mouvementValue.Get<Vector2>();
//         mouvementx= mouvementVector.x;
//         mouvementy= mouvementVector.y;

//     } 
    void SetCountText()
    {
        countText.text= "score:" +compteur.ToString();
        if (compteur>=6)
        {
            winTextObject.SetActive(true);
        }
        
    }

    private void OnTriggerEnter(Collider other)//detecte le contact sans créer de collisions
    {
        if (other.gameObject.CompareTag("PickUp")) 
        {
            other.gameObject.SetActive(false);
            compteur+=1;
            SetCountText();
        }

    }
}


