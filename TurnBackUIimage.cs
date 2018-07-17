using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnBackUIimage : MonoBehaviour {

	[SerializeField] private RawImage customImage;

	void OnTriggerEnter(Collider other)
		{
			
				customImage.enabled = true;
			
	}
	
	// Update is called once per frame
	void OnTriggerExit(Collider other) 
	{
		
			customImage.enabled = false;
		
	}
}
