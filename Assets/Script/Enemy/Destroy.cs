﻿using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Invoke("die", 0.5f);
	}

    private void die()
    {
        Destroy(gameObject);
    }
}
