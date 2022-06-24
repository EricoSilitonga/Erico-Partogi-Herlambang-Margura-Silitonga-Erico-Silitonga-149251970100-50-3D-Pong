using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    private float _timer = 0;
    public float interval = 5;
    private int randomizerCannon;
    public int ballMax = 5;
    private int ballCount;
    public GameObject CM1,CM2,CM3,CM4;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        ballCount = 0;
        _timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Timer untuk ngelakuin spawn objek dari randomized cannon
        _timer += Time.deltaTime;

        if (_timer > interval)
        {
            Debug.Log("FIREE!!!");
            randomizerCannon = Random.Range(1, 4);
            if(ballCount <= ballMax)
            {
                if (randomizerCannon == 1)
                {
                    CM1.GetComponent<CannonManager>().Fire(1);
                    ballCount++;
                }
                else if (randomizerCannon == 2)
                {
                    CM2.GetComponent<CannonManager>().Fire(2);
                    ballCount++;
                }
                else if (randomizerCannon == 3)
                {
                    CM3.GetComponent<CannonManager>().Fire(3);
                    ballCount++;
                }
                else if (randomizerCannon == 4)
                {
                    CM4.GetComponent<CannonManager>().Fire(4);
                    ballCount++;
                }
            }
            _timer -= interval;
        }
    }

    public void ReduceBall()
    {
        ballCount--;
    }
}
