using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class middleBox : MonoBehaviour
{
    public LogicManager logic;
    private BirdScript bird;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicManager>();
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("add score");
        if (collision.gameObject.layer==3)
        {
            Debug.Log("add score");
            logic.addScore(1, bird.checkIfBirdAlive());
        }

    }
}
