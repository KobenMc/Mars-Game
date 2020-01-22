using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    public float speed = 4.5f;
    public Transform target;
    private bool checkTrigger;
    int health = 75;
    Rigidbody2D myRb;
    SpriteRenderer mySr;
    Animator myAnim;
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
       
        mySr = GetComponent<SpriteRenderer>();
        myAnim = GetComponent<Animator>();
        myRb = GetComponent<Rigidbody2D>();
        //Find player
        target = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Death();
    }

    void Movement()
    {
        //Go to player only on x axis
        float dist = Vector3.Distance(target.transform.position, transform.position);
        //Find if player is 10 blocks away and drone isn't dead
        if (dist < 10)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(target.position.x, transform.position.y), speed * Time.deltaTime);
            myAnim.SetInteger("drone", 2);
        }
    }
    void Death()
    {
        if (health <= 0)
        {
            myAnim.SetInteger("drone", 3);
            Object.Destroy(self, 1);
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "sword")
        {
            health -= 25;
        }
    }
}
