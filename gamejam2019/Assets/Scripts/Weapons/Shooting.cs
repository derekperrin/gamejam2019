using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    [SerializeField] private GameObject laser;
    [SerializeField] private float fireLength;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    virtual public void Shoot(GameObject origin)
    {
        GameObject laser = GameObject.Instantiate(this.laser, this.gameObject.GetComponent<Transform>(), true);
    }
}
