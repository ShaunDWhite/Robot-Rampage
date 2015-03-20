using UnityEngine;
using System.Collections;

public class s_Wall_Move_1 : MonoBehaviour {

	public bool moveUp;
	public bool moveDown;
	public bool bang;

	// Use this for initialization
	void Start () {
		moveUp = true;
		moveDown = false;
	}
	
	// Update is called once per frame
	//void Update () {
	//	if(GameObject.Find ("Bullet").GetComponent<s_BulletDestroy> ().bang == true){
			//MoveWalls();
	//	}
	//}

	void Update(){
		if (moveUp == true) {
			transform.Translate (0, 0, Time.deltaTime + 0.2f);
		}
		if (moveDown == true) {
			transform.Translate (0, 0, -(Time.deltaTime + 0.2f));
		}
		
		if (transform.position.x >= 27) {
				print ("oooooh magic walls");
				moveUp = false;
				moveDown = true;			
		}

		if (transform.position.x <= -21.5) {
			moveUp = true;
			moveDown = false;
		}
	}
}