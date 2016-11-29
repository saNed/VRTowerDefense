using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	public int startingHealth = 100;
	public int currentHealth;

	void Awake ()
	{
		currentHealth = startingHealth;
	}
		
	public void TakeDamage (int amount)
	{

		currentHealth -= amount;

		if(currentHealth <= 0)
		{
			Destroy (gameObject);
		}
	}
}

/// Tutorial I was referencing
/// https://unity3d.com/learn/tutorials/projects/survival-shooter/harming-enemies?playlist=17144