using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTurtle : MonoBehaviour
{
    public GameObject turtle;
    public GameObject player;
    float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(3.0f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0.0f)
        {
            GameObject newTurtle = Instantiate(turtle, transform.position, Quaternion.identity);
            timer = Random.Range(3.0f, 10.0f);
            //newTurtle.transform.LookAt(player.transform);
        }
            //newTurtle.transform.LookAt(player.transform);
        //newTurtle.transform.LookAt(player.transform);
    }
}
