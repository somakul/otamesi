using UnityEngine;
using System.Collections;

public class MethodScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.M)) {
			MethodOn();
		}
	}

		void MethodOn(){
		Debug.Log ("MethodOn");
	
	}
}
