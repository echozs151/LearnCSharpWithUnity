using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour {

    public GameObject bulletType;
    Transform bulletSpawn;
    public float bSpeed = 6.0f;

    // Use this for initialization
    void Start () {
        bulletSpawn = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0))
        {
            Fire();
        }
	}
    void Fire()
    {
        //Creat bullet object
        var bullet = (GameObject)Instantiate(bulletType, bulletSpawn.position, bulletSpawn.rotation);
        //Velocity of projectile
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bSpeed;
        //Destroy bullet
        Destroy(bullet, 2.0f);

    }
}
