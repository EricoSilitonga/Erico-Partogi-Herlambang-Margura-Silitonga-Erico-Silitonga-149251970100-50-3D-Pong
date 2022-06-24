using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorerManager : MonoBehaviour
{
    public GameObject scorer;
    public GameObject wall;
    public GameObject paddle;
    [SerializeField]
    private int health = 15;
    public BallManager bm;
    public MainMenuController controller;

    private void Start()
    {
        
    }

    private void Update()
    {
        if(health <= 0)
        {
           paddle.SetActive(false);
            wall.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball")&& health > 1)
        {
            health--;
            bm.ReduceBall();
            Destroy(other.gameObject);
        }
        else
        {
            health--;
            bm.ReduceBall();
            Destroy(other.gameObject);
            controller.ReducePlayer();
        }
    }

    public int GetHealth()
    {
        return health;
    }
}
