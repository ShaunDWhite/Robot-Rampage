﻿using UnityEngine;
using System.Collections;

public class s_WallMove_16 : MonoBehaviour {

	public bool moveUp;
	public GameObject ControlPanel_3;
	
	// Use this for initialization
	void Start () {
		moveUp = true;
	}
	
	//Update is called once per frame
	void Update () {
		if(ControlPanel_3 == null){ 		
			MoveWall_16();
		}
	}
	
	void MoveWall_16(){
		if (moveUp == true) {
			transform.Translate (0, 0, Time.deltaTime + 0.9f);
		}
		
		
		if (transform.position.z >= 93) {
			moveUp = false;
		}
		
		
	}
}
