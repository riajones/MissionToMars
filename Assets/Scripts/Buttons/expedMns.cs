using UnityEngine;
using System.Collections;

public class expedMns : MonoBehaviour {

	void OnMouseDown(){
		GameObject lnchExped = GameObject.Find ("launchExpedition");
		if(lnchExped.GetComponent<launchExpedition> ().counter > 0)
			lnchExped.GetComponent<launchExpedition> ().counter--;
		
	}
}
