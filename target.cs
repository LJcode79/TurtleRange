using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public GameObject explosionrubble;
    public GameObject deathOfTurtle;
    Animator anim;
    public bool isDebug=false;
    public bool disableWhenHit = true;
    bool isDead = false;
    bool explosionActive = false;
    appManager appManager;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        transform.rotation = Quaternion.Euler(-5, 0, 6);
        appManager = GameObject.Find("ApplicationManager").GetComponent<appManager>();
        deathOfTurtle.SetActive(false);
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name.Contains("Spell"))
        {
            if (isDebug)
                Debug.Log("hit target");

            //enable the explosion particle effect
            explosionrubble.SetActive(true);
            explosionActive = true;
            if(disableWhenHit)
                //disable the target wall
                gameObject.SetActive(false);
            explosionActive = false;
            
        }
        if (other.gameObject.name.Contains("Arrowhead collider"))
        {
            if (isDead == false)
            {
                appManager.turtlesKilled += 1;
            }
            //deathOfTurtle.Play();
            deathOfTurtle.SetActive(true);
            isDead = true;
            transform.GetComponent<Collider>().enabled = false;
            transform.GetComponent<Rigidbody>().isKinematic = true;
           Destroy(transform.parent.gameObject,3);
        }
    }

    void Update()
    {
        if (explosionActive)
        {
            explosionrubble.transform.position = transform.position;
        }
        if (isDead != true)
        {
            transform.position += new Vector3(0, 0, .01f);
        }
        anim.SetBool("dead", isDead);
    }
}
