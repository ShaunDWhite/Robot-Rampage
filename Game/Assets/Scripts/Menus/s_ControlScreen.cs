using UnityEngine;
using System.Collections;

public class s_ControlScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		if (gameObject.name == "Back") {
			Application.LoadLevel("Main_Menu");
		}
	}

}
