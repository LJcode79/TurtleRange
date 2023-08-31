using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkStart : MonoBehaviour
{
    appManager appManager;

    void Start()
    {
        appManager = GameObject.Find("ApplicationManager").GetComponent<appManager>();
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name.Contains("Arrowhead collider"))
        {
            appManager.startGame();
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}
