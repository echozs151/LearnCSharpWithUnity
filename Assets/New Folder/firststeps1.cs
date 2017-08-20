using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firststeps1 : MonoBehaviour {
    public float OtherControl;
    public float Control;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
        Mathf.Sin(Control) * OtherControl,
        Mathf.Cos(Control) * OtherControl,
        Control * OtherControl);
    }
}
