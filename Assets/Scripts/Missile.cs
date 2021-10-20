using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    
    public void SetTarget(Transform target)
    {
        
        float direction = Mathf.Atan2(target.position.y - transform.position.y, target.position.x - transform.position.x) * Mathf.Rad2Deg;

        transform.Rotate(new Vector3(0,0,1), direction);
 
    }
}
