using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public GameObject sword;
    // Start is called before the first frame update
    void Start()
    {
        sword.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    void Attack()
    {
        if (Input.GetKey("space"))
        {
            sword.SetActive(true);

        }
    }
}
