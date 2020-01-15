using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public int CurrentHealth = 100;
    
    public bool DieOnZero = true;

    public UnityEvent DamageFunctions;
    public UnityEvent DeathFunctions;
    
    private bool DeathOccured = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Damage(int damage)
    {
        CurrentHealth -= damage;
        //is death happening?
        if (CurrentHealth <= 0 && !DeathOccured)
        {
            CurrentHealth = 0;
            //run any effects and functions to happen when death occurs
            DeathFunctions.Invoke();
            DeathOccured = true;
            if (DieOnZero)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            //run any effects and functions to happen when damage occurs, not kept so it never happens at death
            DamageFunctions.Invoke();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
