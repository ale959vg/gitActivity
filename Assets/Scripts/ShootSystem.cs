using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSystem : ShootingSystem
{
    

  

    public  void Shoot2()
    {
        var shot = Instantiate(
             shootingdata.projectile, shotPoint.position, shotPoint.rotation);
        shot.GetComponent<Rigidbody2D>().AddForce(
            shotPoint.transform.up * shootingdata.fireForce);
    }

    public override void Shoot()
    {
        GameObject shot = PoolingManager.Instance.GetPooledObject();
        if(shot != null)
        {
            shot.transform.position = shotPoint.position;
            shot.transform.rotation = shotPoint.rotation;
            shot.SetActive(true);
            shot.GetComponent<Rigidbody2D>().AddForce(transform.up * shootingdata.fireForce);

        }
    }
}
