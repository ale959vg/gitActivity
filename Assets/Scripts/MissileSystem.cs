using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSystem : ShootingSystem

{
    public override void Shoot()
    {
        var mis = Instantiate(
            shootingdata.projectile, shotPoint.position, shotPoint.rotation);
        mis.GetComponent<Missile>().SetTarget(
            GameObject.Find("Meteor").transform);
    }

 
}
