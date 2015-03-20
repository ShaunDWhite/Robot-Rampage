using UnityEngine;
using System.Collections;

public class s_PlayerWin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x >= 135){
			print ("you win");
		}
	
	}
}
