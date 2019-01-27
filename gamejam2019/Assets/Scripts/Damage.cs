using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

    [SerializeField] protected int currentDamage; // the amount of damage that will be applied to another object when this object collides with it.
    [SerializeField] protected int maxDamage; // the max amount of damage that this object can be set to apply
    [SerializeField] protected int minDamage; // the min amount of damage that this object can be set to apply.

    /***
     * Sets the current damage to the given value.
     */
    virtual public void setDamage(int damage)
    {
        if (damage > maxDamage)
        {
            currentDamage = maxDamage;
            return;
        }
        if (damage < minDamage)
        {
            currentDamage = minDamage;
            return;
        }
        currentDamage = damage;
    }

    /***
     * Changes the current damage by given value.
     */
    virtual public void changeDamage(int change)
    {
        setDamage(currentDamage + change);
    }

    /***
     * Sends a message to the game object that was touched to lower health by the current damage in this script (currentDamage).
     */
    virtual protected void OnTriggerEnter2D(Collider2D collider)
    {
        collider.gameObject.SendMessage("ChangeHealth", -currentDamage); // make power negative because we want to take away health.
    }
}
