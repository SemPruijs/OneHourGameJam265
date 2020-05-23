using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject pushBullet;
    public GameObject explodeBullet;

    public GameObject shootPoint;

    private void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Shoot(pushBullet);
        } else if (Input.GetKeyDown("space"))
        {
            Shoot(explodeBullet);
        }
    }

    void Shoot(GameObject bullet)
    {
        Instantiate(bullet, shootPoint.transform.position, transform.rotation);
    }
}
