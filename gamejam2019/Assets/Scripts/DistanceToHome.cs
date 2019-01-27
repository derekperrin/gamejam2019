using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

        if (currentDistanceToHome <= 0)
        {
            uiElement.text = "YOU ARE HOME!!!!";
        }
        else
        {
            uiElement.text = "Distance to home: " + currentDistanceToHome.ToString() + " light years.";
        }
	}
}
