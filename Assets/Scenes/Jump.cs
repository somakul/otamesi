using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	// Use this for initialization
	private  Rigidbody _rigidbody;
	public float power = 500f;
	void Start () {
		_rigidbody = GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			this._rigidbody.AddForce (Vector3.up * power);
		}
	
	}
}
