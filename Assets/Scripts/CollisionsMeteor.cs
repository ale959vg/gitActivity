using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollisionsMeteor : MonoBehaviour
{
  

    [SerializeField]
    private int damage;

    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<Health>().LooseHP(damage);
       
    }
    
}
