using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PipeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float spawnRate = 3;
    private float timer;
    public float spawnOffset = 10;
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();

        }
    }
    void spawnPipe()
    {
        timer = 0;

        float highestPoint = transform.position.y + spawnOffset;
        float lowestPoint = transform.position.y - spawnOffset;

        Vector3 pos = new Vector3 (transform.position.x, Random.Range(lowestPoint,highestPoint), transform.position.z) ;

        Instantiate(pipe, pos, transform.rotation);

    }
}
