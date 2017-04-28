using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTargetFrameRate : MonoBehaviour {

	// Use this for initialization
	void Awake ()
    {
        Application.targetFrameRate = 30;	
	}
}
