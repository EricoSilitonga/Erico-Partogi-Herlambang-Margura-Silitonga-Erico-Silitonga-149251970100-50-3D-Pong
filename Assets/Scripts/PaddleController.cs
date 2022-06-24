using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode moveUp;
    public KeyCode moveDown;
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(getInput());
    }

    private void MoveObject(Vector3 movement)
    {
        //Debug.Log("TEST: " + movement);
        rig.velocity = movement;
    }

    //Menangkap input dari keyboard
    private Vector3 getInput()
    {
        if (Input.GetKey(moveUp))
        {
            return Vector3.forward * speed;
        } else if (Input.GetKey(moveDown))
        {
            return Vector3.back * speed;
        }else if (Input.GetKey(moveLeft))
        {
            return Vector3.left * speed;
        }else if (Input.GetKey(moveRight))
        {
            return Vector3.right * speed;
        }
        else
        {
            return Vector3.zero;
        }
    }
}
