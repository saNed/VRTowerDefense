 using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

	public Text goldText;
	public static int Gold;
	public int startingGold = 1000;
	public static PlayerStats instance;

	void Awake() {
		if (instance != null) {
			Debug.LogError ("More than one PlayerStats in scene!");
			return;
		}
		instance = this;
	}

	void Start() {
		Gold = startingGold;
		goldText.text = "Gold: " + Gold;
	}

	public void addGold(int a) {
		Gold += a;
		goldText.text = "Gold: " + Gold;
	}

	 
}
