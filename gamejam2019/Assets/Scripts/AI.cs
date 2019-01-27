using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

    private float initPosX;

    // Use this for initialization
    void Start () {

    }

    private void Awake()
    {
        initPosX = transform.position.x;
    }

    private void FixedUpdate()
    {
        SendMessage("BackNForth", initPosX);
    }
}
