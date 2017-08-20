using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanState : ZombieState {

	// Use this for initialization
	virtual public void LookAround()
    {
        GameObject[] Zombies = (GameObject[]);
        GameObject.FindObjectsOfType(typeof(GameObject));
        
        foreach(GameObject go in Zombies)
        {
            ZombieState z - go.GetComponents<ZombieState
        }
          
    }

}
