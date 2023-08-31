using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkM : MonoBehaviour
{
    appManager appManager;
    changeScene sceneChange;

    void Start()
    {
        appManager = GameObject.Find("ApplicationManager").GetComponent<appManager>();
        sceneChange = GameObject.Find("changeScene").GetComponent<changeScene>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Arrowhead collider"))
        {
            appManager.SetDifficulty("Medium");
        }
    }
}
