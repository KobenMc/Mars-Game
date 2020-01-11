using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Character;
    public float Speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        walking();

    }

    void walking()
    {
        float h = Input.GetAxis("Horizontal") * Speed;

        Character.transform.Translate(h * Time.deltaTime, 0, 0);
    }
}
