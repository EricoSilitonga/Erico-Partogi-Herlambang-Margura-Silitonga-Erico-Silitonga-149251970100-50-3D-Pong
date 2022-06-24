using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody rbBall;
    public Vector2 speed;
    private Vector3 temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveBall(temp);
    }

    public void MoveBall(Vector3 velocity)
    {
        rbBall.AddForce(velocity, ForceMode.Impulse);
    }

    public void SetVector(Vector3 vektor)
    {
        temp = vektor;
    }

}
