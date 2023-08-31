using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkE : MonoBehaviour
{
    appManager appManager;
    changeScene sceneChange;

    void Start()
    {
        appManager = GameObject.Find("ApplicationManager").GetComponent<appManager>();
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name.Contains("Arrowhead collider"))
        {
            appManager.SetDifficulty("Easy");
        }
    }
}
