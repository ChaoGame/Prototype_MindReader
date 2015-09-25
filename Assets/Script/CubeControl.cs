using UnityEngine;
using System.Collections;

public class CubeControl : MonoBehaviour {
	public GameObject cube00;
	public GameObject cube01;
	public GameObject cube02;
	//public GameObject deng01;
	//public GameObject deng01;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.JoystickButton2)) {
			cube00.SetActive(true);
			//deng.SetActive(true);
			Debug.Log ("1");
		}
		if (Input.GetKeyDown (KeyCode.JoystickButton1)) {
			cube01.SetActive(true);
			//deng.SetActive(true);

		}
		
		if (Input.GetKeyUp (KeyCode.JoystickButton2)) {
			cube00.SetActive(false);
			//deng.SetActive(false);
			Debug.Log ("2");
		}
		if (Input.GetKeyUp (KeyCode.JoystickButton1)) {
			cube01.SetActive(false);
			//deng.SetActive(false);
		}

		if (Input.GetKeyDown (KeyCode.JoystickButton0)) {
			cube02.SetActive(true);
			//deng.SetActive(true);
		}

		if (Input.GetKeyUp (KeyCode.JoystickButton0)) {
			cube02.SetActive(false);
			//deng.SetActive(false);
		}
	}
}
