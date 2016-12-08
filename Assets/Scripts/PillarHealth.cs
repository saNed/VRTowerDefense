using UnityEngine;
using System.Collections;

public class PillarHealth : MonoBehaviour {

	public static int liveTowers = 4;
	public int startingHealth = 100;
	public int currentHealth;

	void Start () {
		currentHealth = startingHealth;
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Enemy")
			TakeDamage (100);
	}

	public void TakeDamage (int amount)
	{

		currentHealth -= amount;

		if(currentHealth <= 0)
		{
			liveTowers -= 1;
			Debug.Log ("Live towers: " + liveTowers);
			Destroy (gameObject);
			if (liveTowers == 0) {
				Time.timeScale = 0.0f;
			}
		}
	}
}
