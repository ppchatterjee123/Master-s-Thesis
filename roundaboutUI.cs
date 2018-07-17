using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roundaboutUI : MonoBehaviour {

	public int coinValue;
	public Text ScoreText;

	// Use this for initialization
	void Start () {
		coinValue = 0;
	}
	
	// Update is called once per frame
	void Update () {
		ScoreText.text = coinValue.ToString();
		}

	void OnTriggerEnter(Collider other)
		{
		if (other.gameObject.tag == "roundabout"   )
		{
			coinValue = coinValue + 1;
		}
		else
		{
			coinValue = coinValue + 0;
		}
	}
	}