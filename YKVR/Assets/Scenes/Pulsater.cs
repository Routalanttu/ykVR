using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulsater : MonoBehaviour {

	public Transform[] _pathObjects;
	public int _pathIndex;
	private int _prev;
	private float _timer;
	public float _speed = 10f;
	public float _isoKoko = 0.5f;
	public float _pieniKoko = 0.25f;

	// Use this for initialization
	void Start () {
		_timer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		_timer += Time.deltaTime * _speed;


		if (_timer > 1f) {
			_timer = 0f;
			_prev = _pathIndex;
			_pathIndex++;
			if (_pathIndex >= _pathObjects.Length) {
				_pathIndex = 0;
			}
		}

		_pathObjects [_pathIndex].localScale = new Vector3 (_isoKoko, _isoKoko, _isoKoko);
		_pathObjects [_prev].localScale = new Vector3 (_pieniKoko, _pieniKoko, _pieniKoko);
	}
}
