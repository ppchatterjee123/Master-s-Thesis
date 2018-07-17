using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winUI : MonoBehaviour {

	string coinValue;
	public Text ScoreText;

	// Use this for initialization
	void Start () {
		coinValue = "  ";
	}
	
	// Update is called once per frame
	void Update () {
		ScoreText.text = coinValue.ToString();
		}

	void OnTriggerEnter(Collider other)
	{
		ScoreText.text = "You Completed";
		
	}
}
