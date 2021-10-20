using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class ActivateMisile : MonoBehaviour
{
    public static event Action OnPickMissile = delegate { };

    void OnTriggerEnter2D(Collider2D other)
    {
        if (GetComponent<MissileSystem>() == null)
        {
            ShootingSystemData sh = Resources.Load<ShootingSystemData>("MissileData");
            Destroy(other.GetComponent<ShootingSystem>());
            MissileSystem m = other.gameObject.AddComponent<MissileSystem>();
            m.shootingdata = sh;
            m.shotPoint = other.GetComponent<ShipController>().shotPoints[0];
            other.GetComponent<ShipController>().AssignLauncher(m);
        }
        Destroy(gameObject);
    }
}
