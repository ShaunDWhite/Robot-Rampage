using UnityEngine;
using System.Collections;

public class s_MainTitleTheme : MonoBehaviour {

	public AudioClip Theme;

	// Use this for initialization
	void Start () {
		Camera.main.audio.clip = Theme;		
		Camera.main.audio.Play();	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
