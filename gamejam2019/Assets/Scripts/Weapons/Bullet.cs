using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Damage {

    virtual protected void Start()
    {
        Invoke("DestroyBullet", 3);
    }

    override protected void OnTriggerEnter2D(Collider2D collider)
    {
        base.OnTriggerEnter2D(collider);
        DestroyBullet();
    }

    virtual protected void DestroyBullet()
    {
        Destroy(this.gameObject);
    }
}
