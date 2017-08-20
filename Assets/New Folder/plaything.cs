using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plaything : MonoBehaviour {
    public int Control;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Control, Control + Control, Control * Control);
	}
}
