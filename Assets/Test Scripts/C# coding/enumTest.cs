using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enumTest : MonoBehaviour {

    [Flags]
    public enum CarOptions
    {
        // The flag for SunRoof is 0001.
        SunRoof = 0x01,
        // The flag for Spoiler is 0010.
        Spoiler = 0x02,
        // The flag for FogLights is 0100.
        FogLights = 0x04,
        // The flag for TintedWindows is 1000.
        TintedWindows = 0x08,
    }

    // Use this for initialization
    void Start () {
        CarOptions options = CarOptions.SunRoof | CarOptions.Spoiler;
        // Because the Flags attribute is specified, Console.WriteLine displays
        // the name of each enum element that corresponds to a flag that has
        // the value 1 in variable options.
        Debug.Log(options);
       // Console.WriteLine(options);
        // The integer value of 0101 is 5.
        Debug.Log((int)options);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
