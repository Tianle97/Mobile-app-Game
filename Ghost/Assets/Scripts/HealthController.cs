using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour {

    public int maxHealth;

    public HealthBarController healthBarController;

    int health;
    public int GetHealth()
    {
        return health;
    }

    public delegate void GhostDied();
    public event GhostDied OnGhosterDeath;

	// Use this for initialization
	void Start () {
        health = maxHealth;

        UpdateHealthBar();
	}

    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health < 0)
        {
            health = 0;
        }
        UpdateHealthBar();

        if(health == 0)
        {
            if(OnGhosterDeath != null)
            {
                OnGhosterDeath();
            }
        }
    }

    public void Heal(int amout)
    {
        health += amout;
        if(health  > maxHealth)
        {
            health = maxHealth;
        }
        UpdateHealthBar();
    }
	
	// Update is called once per frame
	void UpdateHealthBar() {
        float percentOfHealth = (float)health / maxHealth;

        healthBarController.setHealthBar(percentOfHealth);
		
	}
}
