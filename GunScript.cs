using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {

    public float damage = 10f;
    public float range = 100f;
    public float impactFore = 30;
    public float fireRate = 15f;

    public Camera fpsCam;
    
    public GameObject impactEffect;
    public ParticleSystem impactfloor;

    private float nextTimeToFire = 0f;

    public AudioSource ak47Audio;
  
   
    void Start()
    {
        ak47Audio = GetComponent<AudioSource>();
     
       
    }
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
            ak47Audio.Play();
         
        }
    }

    void Shoot()
    {

        impactfloor.Play();


        RaycastHit hit;
       if( Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }

            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactFore);
            }

         
                Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
          
              
            
        }
    }
}
