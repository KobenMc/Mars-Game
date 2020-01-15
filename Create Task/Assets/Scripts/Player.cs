﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    SpriteRenderer mySr;
    Animator myAnim;
    Rigidbody2D myRb;
    public GameObject player;
    public float Speed = 5.0f;
    public float jumpHeight;
    float h;
    float jump;
    // Start is called before the first frame update
    void Start()
    {
        mySr = GetComponent<SpriteRenderer>();
        myAnim = GetComponent<Animator>();
        myRb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        walking();
        jumping();
    }

    void walking()
    {
        h = Input.GetAxis("Horizontal") * Speed;

        player.transform.Translate(h * Time.deltaTime, 0, 0);
        if(h > 0)
        {
            myAnim.SetInteger("player", 2);
            mySr.flipX = false;
        }
        if(h < 0)
        {

            myAnim.SetInteger("player", 2);
            mySr.flipX = true;
        }
        if(h == 0)
        {
            myAnim.SetInteger("player", 1);
        }
    }
    void jumping()
    {

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "thorns")
        {
            SceneManager.LoadScene("Death");
        }
        if (col.gameObject.tag == "drone")
        {

        }
    }
}
