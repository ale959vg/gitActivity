using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem explosion;
    void OnEnable()
    {
        GetComponent<Health>().OnDeath += Dead;
    }
    void OnDisable()
    {
        GetComponent<Health>().OnDeath -= Dead;
    }

    public void Dead()
    {
        gameObject.SetActive(false);

        if (explosion != null) {
            var exp = Instantiate(explosion, transform.position, Quaternion.identity);         
        }
    }

 
   
}
