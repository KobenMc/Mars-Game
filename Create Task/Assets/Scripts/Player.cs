using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    SpriteRenderer mySr;
    Animator myAnim;
    public GameObject player;
    public float Speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        mySr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        walking();

    }

    void walking()
    {
        float h = Input.GetAxis("Horizontal") * Speed;

        player.transform.Translate(h * Time.deltaTime, 0, 0);
        if(h > 0)
        {
            myAnim 
        }
    }
}
