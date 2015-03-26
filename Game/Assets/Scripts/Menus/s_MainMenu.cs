using UnityEngine;
using System.Collections;

public class s_MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		if (gameObject.name == "Play") {
			Application.LoadLevel("Scene_1");
		} 
	}
}
