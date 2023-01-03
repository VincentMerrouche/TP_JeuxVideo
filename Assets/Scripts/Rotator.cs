using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{


    //On utilise pas start car on utilise pas Force

    // Update is called once per frame
    void Start()
{
    {
        //Decale en fonction du temps
        transform.Rotate(new Vector3(15,0,45)* Time.deltaTime);
        //On veut faire tourner le cube sur lui même 
    }
}
}
