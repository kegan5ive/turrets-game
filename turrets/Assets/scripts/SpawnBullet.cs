using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour 
{
    public KeyCode fire;
   
    public spawn_ Bullet;

    public float TimeBetweenShots;
    public float ShotCounter;

    public Transform FirePoint;

    void Update()
    { 
        ShotCounter -= Time.deltaTime;

        if (Input.GetKey(fire))
        {
           
            if (ShotCounter <= 0)
            {
                ShotCounter = TimeBetweenShots;
                spawn_ newbullet = Instantiate(Bullet, FirePoint.position, FirePoint.rotation) as spawn_;

            }
        }

        
            
        
  
    }
}
