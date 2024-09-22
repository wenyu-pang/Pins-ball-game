using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerattack : MonoBehaviour
{
    //shotting postation
    public Transform firePoint;
    //bullet
    public GameObject b;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            shoot();
        }
    void shoot()
        {
            Instantiate(b,firePoint.position,firePoint.rotation);
        }
    }


}
