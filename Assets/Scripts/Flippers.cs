using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Flippers : MonoBehaviour
{
    public float PositionRepos = 0.0f;
    public float PositionPréssée = 45.0f;
    public float Vitesse =10000.0f;
    public float FlipperDamper=150.0f;
    HingeJoint hinge;

    public string InputName;

    // Start is called before the first frame update
    void Start()
    {
        hinge= GetComponent<HingeJoint>();
        hinge.useSpring=true;
    }

    // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring= Vitesse;
        spring.damper= FlipperDamper;

        if (Input.GetAxis(InputName)==1)
        {
            spring.targetPosition= PositionPréssée;
        }
        else
        {
            spring.targetPosition= PositionRepos;
        }
        hinge.spring =spring;
        hinge.useLimits =true;
    }
}
