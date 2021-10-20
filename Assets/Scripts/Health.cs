using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    [SerializeField]
    private float maxHealth;

    [SerializeField]
    private float HP;

    public event Action<float> HPlost = delegate { };

    public event Action OnDeath = delegate { };

    void Start()
    {
        HP = maxHealth;
        HPlost(HP);
    }
   

    public void LooseHP(int dmg)
    {
        
        HP -= dmg;
        HPlost(HP);
        if(HP <= 0)
        {
            OnDeath();
        }
        
    }
}
