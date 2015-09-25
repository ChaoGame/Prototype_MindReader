using UnityEngine;
using System.Collections;

public class playTestMovie : MonoBehaviour {

public MovieTexture testMovie;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Alpha1))
		{testMovie.Play();}

		if (Input.GetKeyUp(KeyCode.Alpha1))
		{
			testMovie.Pause();
		}
	
	}
}
