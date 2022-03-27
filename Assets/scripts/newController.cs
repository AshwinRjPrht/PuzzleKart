using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newController : MonoBehaviour
{
    public float MovementSpeed;
    public float RotationSpeed;

    public WheelJoint2D BackWheel;
    public WheelJoint2D FrontWheel;
    public Rigidbody2D CarBody;

    private float Movement;
    private float Rotation;

    private void Update()
    {
        //Movement = Input.GetAxisRaw("Vertical") * MovementSpeed;
        //Rotation = Input.GetAxisRaw("Horizontal");
        if (CarButtons.isGasBtnDwn == true)
        {
            Movement = 1 * MovementSpeed;
        }
        else if (CarButtons.isBrakeBtnDwn == true) 
        {
            Movement = -1 * MovementSpeed;
        }
        else
        {
            Movement = 0;
        }
    }
    private void FixedUpdate()
    {
        if(Movement==0)
        {
            BackWheel.useMotor = false;
            FrontWheel.useMotor = false;

        }
        else
        {
            BackWheel.useMotor = true;
            FrontWheel.useMotor = true;

            JointMotor2D motor2D = new JointMotor2D { motorSpeed = Movement, maxMotorTorque = 1000 };
            BackWheel.motor = motor2D;
            FrontWheel.motor = motor2D;
        }
        CarBody.AddTorque(Rotation * RotationSpeed * Time.deltaTime);
    }
     /*void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }*/
}
