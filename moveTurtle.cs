using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTurtle : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        //transform.rotation = Quaternion.Euler(-5, 90, 6);
        //Destroy(gameObject, 20.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, .005f);
    }
}
