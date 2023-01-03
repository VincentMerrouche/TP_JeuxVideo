using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float forcex;
    public float forcez;
    Rigidbody ball;

    void Start () {
        forcex=1.0f;
        forcez=1.0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {


            ball = other.gameObject.GetComponent<Rigidbody>();
            Vector3 direction = ball.transform.position - transform.position;
            ball.AddForceAtPosition(direction.normalized, transform.position);
           
        }
    }


}
