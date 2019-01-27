using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Rigidbody2D rbody;
    private Transform myTransform;
    private bool goingRight;
    private Vector2 right, left;

    public float velocity;
    public float radius;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        myTransform = GetComponent<Transform>();
        goingRight = true;
        right = new Vector2(1, 0);
        left = new Vector2(-1, 0);
        if (radius == 0)
        {
            radius = 5;
        }
    }

    public void Move(Vector2 direction)
    {
        rbody.velocity = direction * velocity;
    }

    public void BackNForth(float center)
    {

        if (goingRight)
        {
            Move(right);
            if (myTransform.position.x >= center + radius)
            {
                goingRight = false;
            }
        }
        else
        {
            Move(left);
            if (transform.position.x <= center - radius)
            {
                goingRight = true;
            }
        }
    }
}
