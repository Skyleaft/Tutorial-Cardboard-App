using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tembak : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject peluru;
    public float fireRate = 0.5F;
    private float nextFire = 0.0F;
    public float liveTime=3f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            spawnPeluru();

        }   
    }

    void spawnPeluru()
    {
        GameObject projectile = Instantiate(peluru) as GameObject;
        projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.velocity = Camera.main.transform.forward * 7;
        Destroy(projectile, liveTime);

    }
}
