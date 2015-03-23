using UnityEngine;
using System.Collections;

public class s_WallMove_8 : MonoBehaviour {

	public bool moveUp;
	public GameObject ControlPanel_2;
	
	// Use this for initialization
	void Start () {
		moveUp = true;
	}
	
	//Update is called once per frame
	void Update () {
		if(ControlPanel_2 == null){ 		
			MoveWall_8();
		}
	}
	
	void MoveWall_8(){
		if (moveUp == true) {
			transform.Translate (0, 0, Time.deltaTime + 0.5f);
		}
		
		
		if (transform.position.x >= 78) {
			moveUp = false;
		}
		
		
	}
}
