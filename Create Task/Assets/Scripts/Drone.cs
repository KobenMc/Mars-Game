using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    public float speed = 4.5f;
    public Transform target;
    private bool checkTrigger;
    SpriteRenderer mySr;
    Animator myAnim;
    // Start is called before the first frame update
    void Start()
    {
        //Find player
        target = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        //Go to player only on x axis
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(target.position.x, transform.position.y), speed * Time.deltaTime);
        
    }
}
