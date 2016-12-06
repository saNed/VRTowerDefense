using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	public int startingHealth = 100;
	public int currentHealth;

	PlayerStats playerStats;

	void Start() {
		playerStats = PlayerStats.instance;
	}

	void Awake ()
	{
		currentHealth = startingHealth;
	}
		
	public void TakeDamage (int amount)
	{

		currentHealth -= amount;

		if(currentHealth <= 0)
		{
			playerStats.addGold(100);
			Destroy (gameObject);
		}
	}
}

/// Tutorial I was referencing
/// https://unity3d.com/learn/tutorials/projects/survival-shooter/harming-enemies?playlist=17144