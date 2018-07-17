﻿using UnityEngine;
using System.Collections;
﻿using UnityEngine;
using System.Collections;

public class controltimer : MonoBehaviour {

	void OnControllerColliderHit(ControllerColliderHit hit) {

		if(hit.gameObject.name == "startRace")
		{
			setTimer(1);
		}

		if(hit.gameObject.name == "finishRace")
		{
			setTimer(0);
		}

	}

	void setTimer(int t){
		timer playerTimer = this.GetComponent<timer>();
		playerTimer.startTimer = t;
	}
}