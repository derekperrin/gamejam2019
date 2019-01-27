using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DistanceToHome : MonoBehaviour {

    [SerializeField] protected Text uiElement;
    [SerializeField] protected float initialDistanceToHome;
    [SerializeField] protected float countDownRate;
    protected float currentDistanceToHome;

	// Use this for initialization
	void Start () {
        currentDistanceToHome = initialDistanceToHome;
	}
	
	// Update is called once per frame
	void Update () {
        currentDistanceToHome -= countDownRate;

        if (currentDistanceToHome <= 0 && currentDistanceToHome > -100)
        {
            uiElement.text = "Distance to home: 0 light years.";
        }
        else if (currentDistanceToHome <= -100)
        {
            print("Loading winner scene");
            SceneManager.LoadScene("WinnerScene");
        }
        else
        {
            uiElement.text = "Distance to home: " + currentDistanceToHome.ToString() + " light years.";
        }
	}
}
