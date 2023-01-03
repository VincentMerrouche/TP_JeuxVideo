using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class PlungerTrigger : MonoBehaviour {
    public float power = 0f;
    public float powerAdd = 10f;
    public float maxPower = 500f;
    public Slider powerSlider;
    public string InputName;
    Rigidbody ball;
 
    void Start () {
        powerSlider.minValue = 0f;
        powerSlider.maxValue = maxPower;
    }
    
    private void Update()
    {
        if (ball != null)
        {
            powerSlider.value = power;

            if (Input.GetKey(KeyCode.Space))
            {
                if(power<=maxPower)  power += 50 * Time.deltaTime;
                
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                ball.AddForce(power *100.0f* Vector3.forward);
            }
        }
        
    }
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            powerSlider.gameObject.SetActive(true);
            ball = other.gameObject.GetComponent<Rigidbody>();
        }
    }
 
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            powerSlider.gameObject.SetActive(false);
            ball = null;
            power = 0f;
        }
    }
}