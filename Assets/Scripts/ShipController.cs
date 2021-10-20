using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public Transform[] shotPoints;
    private ShootingSystem launcher;
    public ShootingSystemData[] shootingData;
    void Awake()
    {
        InputSystemKeyboard sk;
        if (TryGetComponent<InputSystemKeyboard>(out sk))
            sk.lClick += Shoot;
    }

    /*void OnEnable()
    {
        activateShot.OnPickShot += activateShoot;
        activateMisile.OnPickMissile += activateMissile;
    }
    void OnDisable()
    {
        activateShot.OnPickShot -= activateShoot;
        activateMisile.OnPickMissile -= activateMissile;

    }*/

    private void Update()
    {
        var input = Input.inputString;

        if(Input.GetKeyDown(KeyCode.B))
        {
           // activateShoot();
            if (GetComponent<ShootSystem>() == null)
            {
                ShootingSystemData sh = Resources.Load<ShootingSystemData>("ShotData");
                Destroy(gameObject.GetComponent<ShootingSystem>());
                ShootSystem s = gameObject.AddComponent<ShootSystem>();
                s.shootingdata = sh;
                s.shotPoint = shotPoints[0];
                launcher = s;
            }

        }
        if(Input.GetKeyDown(KeyCode.V))
        {
            //activateMissile();
            if (GetComponent<MissileSystem>() == null)
            {
                ShootingSystemData sh = Resources.Load<ShootingSystemData>("MissileData");
                Destroy(gameObject.GetComponent<ShootingSystem>());
                MissileSystem m = gameObject.AddComponent<MissileSystem>();
                m.shootingdata = shootingData[1];
                m.shotPoint = shotPoints[0];
                launcher = m;
            }
        }
    }

    /*public void activateShoot()
    {
        if (GetComponent<ShootSystem>() == null)
        {
            ShootingSystemData sh = Resources.Load<ShootingSystemData>("ShotData");
            Destroy(gameObject.GetComponent<MissileSystem>());
            ShootSystem s = gameObject.AddComponent<ShootSystem>();
            s.shootingdata = shootingData[0];
            s.shotPoint = shotPoints[0];
            launcher = s;
        }
    }

    public void activateMissile()
    {
        if (GetComponent<MissileSystem>() == null)
        {
            ShootingSystemData sh = Resources.Load<ShootingSystemData>("MissileData");
            Destroy(gameObject.GetComponent<ShootSystem>());
            MissileSystem m = gameObject.AddComponent<MissileSystem>();
            m.shootingdata = shootingData[1];
            m.shotPoint = shotPoints[0];
            launcher = m;
        }
    }*/

    void Shoot()
    {
        launcher.Shoot();
    }

    public void AssignLauncher(ShootingSystem a)
    {
        launcher = a;
    }
    
}
