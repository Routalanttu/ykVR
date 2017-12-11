using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swayer : MonoBehaviour {

	private Vector3 _origPos;
	private Transform _transform;
	private float _adder;
	public float _multiplier = 0.5f;

	// Use this for initialization
	void Start () {
		_transform = transform;
		_origPos = _transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		_adder += Time.deltaTime;
		if (_adder >= 360f) {
			_adder = 0f;
		}

		_transform.position = new Vector3 (
			_origPos.x,
			_origPos.y + Mathf.Sin(_adder) * _multiplier,
			_origPos.z
		);
	}
}
