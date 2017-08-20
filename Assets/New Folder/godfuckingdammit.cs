using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class godfuckingdammit : MonoBehaviour {
    GameObject obj;
    Vector3 destination;
    NavMeshAgent agent;
    // Use this for initialization
    void Start () {
        //GameObject obj = null;
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update() {
        //NavMesh
        //NavMeshAgent agent;
        
        agent.destination = destination;



        /*
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            if(obj != hit.collider.gameObject)
            {
                obj = hit.collider.gameObject;
                Debug.Log(obj.name);
            }
           
        }
           */
        if (Input.GetMouseButtonDown(1))
        { 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log(hit.collider.gameObject.name);
                Debug.Log(hit.point.x + " " + hit.point.z);
                destination = hit.point;
            }
        }

    }
}
