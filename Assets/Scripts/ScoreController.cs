using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    private Text Player1;
    [SerializeField]
    private Text Player2;
    [SerializeField]
    private Text Player3;
    [SerializeField]
    private Text Player4;

    public ScorerManager manager1,manager2, manager3, manager4;

    private void Update()
    {
        Player1.text = manager1.GetHealth().ToString();
        Player2.text = manager2.GetHealth().ToString();
        Player3.text = manager3.GetHealth().ToString();
        Player4.text = manager4.GetHealth().ToString();

       
    }

    
}
