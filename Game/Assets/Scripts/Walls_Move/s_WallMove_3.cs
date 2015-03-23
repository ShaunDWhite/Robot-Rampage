using UnityEngine;
using System.Collections;

public class s_WallMove_3 : MonoBehaviour {

	public bool moveUp;
	public GameObject ControlPanel_1;
	
	// Use this for initialization
	void Start () {
		moveUp = true;
	}
	
	//Update is called once per frame
	void Update () {
		if(ControlPanel_1 == null){ 		
			MoveWall_3();
		}
	}
	
	void MoveWall_3(){
		if (moveUp == true) {
			transform.Translate (Time.deltaTime + 0.5f, 0, 0);
		}
		
		
		if (transform.position.z <= -69) {
			moveUp = false;
		}
		
		
	}
}
