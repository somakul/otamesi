using UnityEngine;
using System.Collections;

public class RandomColor : MonoBehaviour {

	// Use this for initialization
	private Renderer _targetRenderer;

	void Awake () {
		_targetRenderer = this.GetComponent<Renderer> ();
	}

	void Start () {
		_targetRenderer.material.color =
			new Color (Random.value, Random.value, Random.value, 1.0f);
	}

	public Color GetBodyColor(){
		return _targetRenderer.material.color; 
	}

	public void ChangeColor(){
		_targetRenderer.material.color = 
			new Color (Random.value, Random.value, Random.value, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
