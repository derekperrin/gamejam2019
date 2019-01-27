using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour {

	private float playerHealthPercentage;
	public Image[] healthImages;
	// Use this for initialization

	void Start() {
		foreach(Image image in healthImages) {
			image.enabled = true;
		}
	}
	public void UpdateHealthBar(){
		playerHealthPercentage = GetComponent<Health>().GetHealth();
		for (int i = healthImages.Length - 1 ; i > Mathf.Floor(playerHealthPercentage*healthImages.Length); i--) {
			healthImages[i].enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
