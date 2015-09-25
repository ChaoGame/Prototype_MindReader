using UnityEngine;
using System.Collections;

public class PlayMovie02 : MonoBehaviour {
public MovieTexture movie02;
	// Use this for initialization
	void Start () {
		movie02.loop = true;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.JoystickButton0)) 
		{
			//((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
			movie02.Play ();
			//audio.Play();
		}
		if (Input.GetKeyUp (KeyCode.JoystickButton0)) {
		
			movie02.Pause();
		}
	
	}
}
