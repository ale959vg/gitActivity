using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doubleShot : ShootingSystem
{
  

    [SerializeField]
    protected Transform doubleShootPoint1;

    [SerializeField]
    protected Transform doubleShootPoint2;


    public override void Shoot()
    {
        var shot = Instantiate(shootingdata.projectile, doubleShootPoint1.position, doubleShootPoint1.rotation);
       shot.GetComponent<Rigidbody2D>().AddForce(doubleShootPoint1.transform.up * shootingdata.fireForce);

        var shot2 = Instantiate(shootingdata.projectile, doubleShootPoint2.position, doubleShootPoint2.rotation);
        shot2.GetComponent<Rigidbody2D>().AddForce(doubleShootPoint2.transform.up * shootingdata.fireForce);
    }
}
