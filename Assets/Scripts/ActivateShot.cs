using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ActivateShot : MonoBehaviour
{

    public static event Action OnPickShot = delegate { };
    void OnTriggerEnter2D(Collider2D other)
    {
        if (GetComponent<ShootSystem>() == null)
        {
            ShootingSystemData sh = Resources.Load<ShootingSystemData>("ShotData");
            Destroy(other.GetComponent<ShootingSystem>());
            ShootSystem s = other.gameObject.AddComponent<ShootSystem>();
            s.shootingdata = sh;
            s.shotPoint = other.GetComponent<ShipController>().shotPoints[0];
            other.GetComponent<ShipController>().AssignLauncher(s);
        
        }
        Destroy(gameObject);
    }
}
