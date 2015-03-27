using UnityEngine;
using System.Collections;

public class s_Reload : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		if (gameObject.name == "Replay") {
			Application.LoadLevel("Scene_1");
		}
		if (gameObject.name == "Return to menu") {
			Application.LoadLevel("Main_Menu");
		}
	}

}
