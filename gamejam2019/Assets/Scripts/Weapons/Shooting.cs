using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shooting : MonoBehaviour {

    [SerializeField] private GameObject laser;
    [SerializeField] private float fireLength;
    private bool shootEnabled;
    private AudioSource source;
    public AudioClip soundfx;

	// Use this for initialization
	void Start () {
        shootEnabled = true;
    }

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    virtual public void Shoot()
    {
        if (!shootEnabled) return;
        shootEnabled = false;
        Invoke("enableShoot", fireLength);
        Vector3 startPosition = this.gameObject.GetComponent<Transform>().position;
        GameObject laser = GameObject.Instantiate(this.laser, new Vector3(startPosition.x, startPosition.y, startPosition.z), Quaternion.identity);
        laser.SendMessage("Move", new Vector2(0, 1));
        source.PlayOneShot(soundfx, 1f);
    }

    private void enableShoot()
    {
        shootEnabled = true;
    }
}
