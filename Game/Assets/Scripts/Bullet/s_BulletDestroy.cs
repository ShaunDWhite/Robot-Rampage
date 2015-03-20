using UnityEngine;
using System.Collections;

public class s_BulletDestroy : MonoBehaviour {

	public bool bang;

	// Use this for initialization
	void Start () {
		bang = false;
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, 4);	
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Wall") {
			Destroy(gameObject);
		}
		if (col.gameObject.tag == "Control Panel") {
			Destroy(gameObject);
			Destroy(col.gameObject);
			print ("bam");
			bang = true;
		}



	}
}
