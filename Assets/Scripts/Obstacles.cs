using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacles : MonoBehaviour
{
    Rigidbody ball;
    public float power;
    float poweractuel;
    // Start is called before the first frame update

    private void Update()
    {
        if (ball != null)
        {
            poweractuel = power;
            ball.AddForce(power* Vector3.forward);

        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
    if (other.gameObject.CompareTag("Ball"))
        {
            ball = other.gameObject.GetComponent<Rigidbody>();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ball = null;
            poweractuel = 0f;
        }
    }
}
