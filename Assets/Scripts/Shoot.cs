using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Transform laserSpawn;

    public GameObject projectile;

    public float nextFire = 1.0f;
    public float currentTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        laserSpawn = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
        
    }

    void shoot()
    {
        currentTime += Time.deltaTime;

        if(Input.GetButton("Fire1") && currentTime > nextFire)
        {
            nextFire += currentTime;

            Instantiate(projectile, laserSpawn.position, Quaternion.identity);

            nextFire -= currentTime;
            currentTime = 0.0f;
        }
    }
}
