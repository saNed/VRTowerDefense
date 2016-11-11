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
			Destroy (gameObject, 2f);
		}
	}
}
