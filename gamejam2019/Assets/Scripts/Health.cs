using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public int startingHealth=100; // Amount of health object starts with
    [SerializeField]private int currentHealth; // current health of the object
    [SerializeField]private bool dmgd; // true when player takes damage, false otherwise
    [SerializeField]private bool dead; // true when the object should be dead


    // Use this for initialization
    void Start () {
        currentHealth = startingHealth;
        dead = false;
    }
	
	// Update is called once per frame
	void Update () {
        // ANIMATIONS AND SUCH?



        dmgd = false;  // reset the damage to false
	}

    // changes current health of the object if it is not dead
    void ChangeHealth(int amount)
    {
        if(amount < 0)
        {
            dmgd = true; //object took damage
        }
        if(amount > 0)
        {
            dmgd = false; //object was healed 
        }

        if ((currentHealth + amount) < startingHealth)
        {
            currentHealth += amount; //applying or heal to current health
        }

        if(currentHealth <= 0 && !dead)
        {
            Death();
        }

    }

    void Death()
    {
        dead = true;
        
        // HAVE TO TURN OFF FEATURES OF MOVEMENT AND SHOOTING HERE
    }

  
}
