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

    IEnumerator Disapear()
    {
        yield return new WaitForSeconds(0.5f);
        sword.SetActive(false);
    }

    void Attack()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sword.SetActive(true);
            StartCoroutine(Disapear());
        }
    }
}
