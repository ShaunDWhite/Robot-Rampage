using UnityEngine;
using System.Collections;

public class s_MainToControl : MonoBehaviour {

	//public Camera MainCamera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		if (gameObject.name == "Controls") {
			Camera.main.camera.transform.Translate(26.5f, 0f, 0f); 
		}
		if (gameObject.name == "Back") {
			Camera.main.camera.transform.Translate(-26.5f, 0f, 0f); 
		}

	}

}
