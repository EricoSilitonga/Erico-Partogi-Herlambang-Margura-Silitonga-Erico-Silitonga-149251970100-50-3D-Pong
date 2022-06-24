using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ballPrefab;
    public Transform firePoint;
    private static int valueX = 8, valueZ = 8;
    public ParticleSystem ps;

    private Vector3 _velocity1 = new Vector3(valueX,0, valueX); //Ke kanan atas
    private Vector3 _velocity2 = new Vector3(-valueX, 0, valueZ); //Ke kiri atas
    private Vector3 _velocity3 = new Vector3(-valueX, 0, -valueZ); //Ke kiri bawah
    private Vector3 _velocity4 = new Vector3(valueX, 0, -valueZ); //Ke kanan bawah
    void Start()
    {
        
    }

    public void Fire(int val)
    {
        GameObject ball = Instantiate(ballPrefab, firePoint.position, Quaternion.identity);

        Rigidbody rb = ball.GetComponent<Rigidbody>();

        if (val == 1)
        {
            AudioManager.instance.PlaySFX(0);
            ps.Play();
            rb.AddForce(_velocity1, ForceMode.Impulse);
            ballPrefab.GetComponent<BallController>().SetVector(_velocity1);
        }
        else if (val == 2)
        {
            AudioManager.instance.PlaySFX(0);
            ps.Play();
            rb.AddForce(_velocity2, ForceMode.Impulse);
            ballPrefab.GetComponent<BallController>().SetVector(_velocity2);
        }
        else if (val == 3)
        {
            AudioManager.instance.PlaySFX(0);
            ps.Play();
            rb.AddForce(_velocity3, ForceMode.Impulse);
            ballPrefab.GetComponent<BallController>().SetVector(_velocity3);
        }
        else if (val == 4)
        {
            AudioManager.instance.PlaySFX(0);
            ps.Play();
            rb.AddForce(_velocity4, ForceMode.Impulse);
            ballPrefab.GetComponent<BallController>().SetVector(_velocity4);
        }

    }


}
