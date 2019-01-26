using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Damage {

    override protected void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
        Destroy(this.gameObject);
    }
}
