using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMotion : MonoBehaviour
{
    public CharacterController controller;

    public float maxForce;
    public float minForce;
    public float forceStep;

    [SerializeField]
    float force;

    public float dash;
    public int dashCooldown;
    int dashCD;

    public Rigidbody body;

    public Vector3 FORWARD;
    public Vector3 BACK;
    public Vector3 LEFT;
    public Vector3 RIGHT;

    // Start is called before the first frame update
    void Start()
    {
        FORWARD.Normalize();
        BACK.Normalize();
        LEFT.Normalize();
        RIGHT.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (controller.getKey(controller.binds.Forward)) 
        {
            body.AddForce(FORWARD * force, ForceMode.Force);
        }
        if (controller.getKey(controller.binds.Back))
        {
            body.AddForce(BACK * force, ForceMode.Force);
        }
        if (controller.getKey(controller.binds.Left))
        {
            body.AddForce(LEFT * force, ForceMode.Force);
        }
        if (controller.getKey(controller.binds.Right))
        {
            body.AddForce(RIGHT * force, ForceMode.Force);
        }
        if (dashCD == 0) 
        {
            if (controller.getKey(controller.binds.Dash))
            {
                if (controller.getKey(controller.binds.Forward))
                {
                    body.AddForce(FORWARD * dash, ForceMode.VelocityChange);
                }
                if (controller.getKey(controller.binds.Back))
                {
                    body.AddForce(BACK * dash, ForceMode.VelocityChange);
                }
                if (controller.getKey(controller.binds.Left))
                {
                    body.AddForce(LEFT * dash, ForceMode.VelocityChange);
                }
                if (controller.getKey(controller.binds.Right))
                {
                    body.AddForce(RIGHT * dash, ForceMode.VelocityChange);
                }
                dashCD = dashCooldown;
            }
        }
    }

    private void FixedUpdate()
    {
        if (dashCD > 0) dashCD--;
        if (!controller.anyDirection()) force = minForce;
        else if (force < maxForce) force += forceStep;
    }
}
