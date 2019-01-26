using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    private Vector2 speed;
    private Vector2 direction;

    // Use this for initialization
    void Start () {
        speed = new Vector2(0, 5);
        direction = new Vector2(0, 1);
    }
	
	// Update is called once per frame
	private void FixedUpdate () {
        // Movement
        Vector3 movement = new Vector3(
          speed.x * direction.x,
          speed.y * direction.y,
          0);

        movement *= Time.deltaTime;
        transform.Translate(movement);
    }
}
