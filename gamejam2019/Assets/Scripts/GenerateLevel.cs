using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour {

    public float timeInterval1, timeInterval2;
    private GameObject topWall;
    private Vector3 spawnPos;
    public double timer;

    public GameObject[] instances;

	// Use this for initialization
	void Start () {
        timer = 5;
        timeInterval1 = Random.Range(0f, (float) timer);
        timeInterval2 = Random.Range(0f, (float) timer);
        topWall = GameObject.Find("Wall (3)");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        timer -= 0.001;

        timeInterval1 -= Time.deltaTime;
        timeInterval2 -= Time.deltaTime;
        if (timeInterval1 < 0)
        {
            timeInterval1 = spawn(timeInterval1);
        }
        if (timeInterval2 < 0)
        {
            timeInterval2 = spawn(timeInterval2);
        }
    }

    private float spawn(float timeInterval)
    {
        spawnPos = topWall.transform.position;
        spawnPos.y += 2;
        spawnPos.x = Random.Range(-10, 10);
        Instantiate(instances[Random.Range(0, instances.Length)], spawnPos, Quaternion.identity);
        return Random.Range(0, (float) timer);
    }
}
