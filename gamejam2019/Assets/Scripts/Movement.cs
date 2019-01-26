using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Rigidbody2D rbody;
    public float velocity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 direction)
    {
        rbody.velocity = direction * velocity;
    }

    public void ScrollUp()
    {
        float Y = transform.position.y;
        float X = transform.position.x;

        Y = Y + (float)0.05;
        Vector3 NewPos = new Vector3(X, Y, 0);
        gameObject.transform.position = NewPos;
    }
}
