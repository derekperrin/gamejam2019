﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        //Move in input direction
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        bool fire = Input.GetButton("Fire1");

        Vector2 direction = new Vector2(h, v);
        direction.Normalize();
        SendMessage("Move", direction);
        if (fire) SendMessage("Shoot", this.gameObject);
    }
}
