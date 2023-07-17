using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicManager logic;
    private bool birdAlive;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicManager>();
        birdAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdAlive)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;

        }

        if ((transform.position.y < -10 || transform.position.y > 10) && birdAlive) { 
            Debug.Log("object is out of frame");
            triggerGameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        triggerGameOver();
    }
    private void triggerGameOver()
    {
        birdAlive = false;
        logic.gameOver();
    }
    public bool checkIfBirdAlive()
    {
        return birdAlive;
    }
}
