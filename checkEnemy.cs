using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkEnemy : MonoBehaviour
{
    public AudioSource audio;
    appManager appManager;

    void Start()
    {
        appManager = GameObject.Find("ApplicationManager").GetComponent<appManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Debug.Log(other);
            audio.Play();
            appManager.livesLeft -= 1;
            Destroy(other.transform.parent.gameObject);
        }
    }
}
