using System.Collections;
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
    public Vector2 jumpHeight;
    float h;
    bool jump;
    int health = 100;
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
        Death();
    }
    //walking mechanic
    void walking()
    {
        h = Input.GetAxis("Horizontal") * Speed;
        player.transform.Translate(h * Time.deltaTime, 0, 0);
        //Triggering walking animations
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
    //jumping mechanic
    void jumping()
    {
        if (jump == false)
        {
            if (Input.GetAxis("Jump") > 0)
            {

                myAnim.SetBool("Grounded", false);
                GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
                jump = true;
            }
        }
    }

    void Death()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("Death");
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        //Death by thorns
        if (col.gameObject.tag == "thorns")
        {
            SceneManager.LoadScene("Death");
        }
        //collision with drone to cause damage to player
        if (col.gameObject.tag == "drone")
        {
            health -= 25;
        }
        if (col.gameObject.tag == "ground")
        {
            jump = false;
            myAnim.SetBool("Grounded", true);
        }
    }
}
