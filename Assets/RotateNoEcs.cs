﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateNoEcs : MonoBehaviour {

    public float speed;
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0f, speed * Time.deltaTime, 0f);
    }
}
