using UnityEngine;
using System.Collections;

public class launchExpedition : MonoBehaviour {
	public bool onMenu;
	int timer;
	int sent;
	public int counter;

	GameObject gameController;

	GameObject popDisp;
	GameObject num;

	void Start () {
		gameController = GameObject.Find ("Game_Controller");
		popDisp = GameObject.Find ("popToExpedition");
		num = GameObject.Find("numSend");
		onMenu = false;
		counter = 0;
		timer = 1;
	}

	void Update () {

		//Creates the gui items on the menu
		if (onMenu) {
			popDisp.guiText.enabled = true;
			num.guiText.enabled = true;
			string numSend = counter.ToString() + " / " + gameController.GetComponent<game_controller>().population.ToString();
			num.guiText.text = numSend;
			GameObject tempObj = GameObject.Find ("expeditionPlus");
			tempObj.guiTexture.enabled = true;
			tempObj = GameObject.Find ("expedtitionMinus");
			tempObj.guiTexture.enabled = true;
			gameController.GetComponent<game_controller>().isHud = false;
		}
		else if(!onMenu){
			popDisp.guiText.enabled = false;;
			num.guiText.enabled = false;
			GameObject tempObj = GameObject.Find ("expeditionPlus");
			tempObj.guiTexture.enabled = false;
			tempObj = GameObject.Find ("expedtitionMinus");
			tempObj.guiTexture.enabled = false;
		}

		/*Waits until the expedition has finished
		Once the expedition is over it picks a random number to determine success
		Then randomizes rewards / Penalties*/
		if(timer <= 0){
			CancelInvoke();
			timer = 1;
			int success = Random.Range (1,100);
			if(success >= gameController.GetComponent<game_controller>().expeditionSuccessRate){
				int reward = Random.Range (0, sent);
				int popRet = Random.Range (1, 100);
				reward = reward * sent;
				int survivors = sent * popRet / 100;
				gameController.GetComponent<game_controller>().ore += reward;
				gameController.GetComponent<game_controller>().population += survivors;
				GameObject temp = GameObject.Find("disasterText");
				string msg = "Expedition was a success!\n You have gained " + reward.ToString() + " ore\n There were " + survivors.ToString() + " survivors";
				temp.guiText.text = msg;
			}
			else{
				GameObject temp = GameObject.Find("disasterText");
				string msg = "Expedition Failed!\n There were 0 Survivors";
				temp.guiText.text = msg;
			}

		}
	}

	void OnMouseDown(){
		timer = 45;
		sent = counter;
		counter = 0;
		InvokeRepeating ("countDown", 1.0f, 1.0f);
		onMenu = false;;

		GameObject gameController = GameObject.Find ("Game_Controller");
		Camera.main.transform.position = gameController.GetComponent<game_controller>().cameraWasHere;
		Camera.main.transform.rotation = gameController.GetComponent<game_controller>().camRot;
		gameController.GetComponent<game_controller> ().movement = true;
		gameController.GetComponent<game_controller> ().isHud = true;
		

		gameController.GetComponent<game_controller> ().population -= sent;



	}

	void countDown(){
		timer--;
	}
}
