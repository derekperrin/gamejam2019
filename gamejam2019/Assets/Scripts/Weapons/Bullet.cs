using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Damage {

    virtual protected void Start()
    {
        Invoke("Die", 3);
    }

    override protected void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
        Die();
    }

    virtual protected void Die()
    {
        Destroy(this.gameObject);
    }
}
