using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

    private float initPosX;
    private GameObject player;

    public int type;        //Type of enemy
                            //1 = Back and Forth

    // Use this for initialization
    void Start () {

    }

    private void Awake()
    {
        initPosX = transform.position.x;
        player = GameObject.Find("Player");
    }

    private void FixedUpdate()
    {
        if (type == 1)
        {
            SendMessage("BackNForth", initPosX);
        }
        else if (type == 2)
        {
            SendMessage("Towards", player.transform);
        }
    }
}
