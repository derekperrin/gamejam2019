using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    public Vector2 speed;
    public bool asteroidInitAcceleration;

    private float timeBeforeAcceleration;
    private Vector2 direction;

    // Use this for initialization
    void Start () {
        if (speed.y == 0)
        {
            speed = new Vector2(0, 5);
        }
        direction = new Vector2(0, 1);
        timeBeforeAcceleration = 2;
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

        //Asteroid acceleration
        if (asteroidInitAcceleration)
        {
            timeBeforeAcceleration -= Time.deltaTime;
            if (timeBeforeAcceleration < 0)
            {
                speed.y = -12;
            }
        }
    }
}
