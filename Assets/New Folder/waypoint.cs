using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoint : MonoBehaviour {
    //Vector3 pos;
   // public Transform gunObj;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, 100))
            print("Hit something!");


    }

    void setWaypoint()
    {
        /*
        // create a ray going into the scene from the screen location the user clicked at
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // the raycast hit info will be filled by the Physics.Raycast() call further
        RaycastHit hit;

        // perform a raycast using our new ray. 
        // If the ray collides with something solid in the scene, the "hit" structure will
        // be filled with collision information
        if (Physics.Raycast(ray, out hit))
        {
            // a collision occured. Check if it's our plane object and create our cube at the
            // collision point, facing toward the collision normal
            if (hit.collider == yourPlaneCollider)
                Instantiate(yourCubePrefab, hit.point, Quaternion.LookRotation(hit.normal));
        }*/

        
    }
}
