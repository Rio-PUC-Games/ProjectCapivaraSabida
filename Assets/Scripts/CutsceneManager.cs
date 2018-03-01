﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneManager : MonoBehaviour {
	public GameObject ObjectToActivate;
	public PlayableDirector Timeline;
	private float _length;

	// Use this for initialization
	void Awake () {
		_length = (float) Timeline.duration;
		StartCoroutine (CutsceneCut());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator CutsceneCut(){
		yield return new WaitForSeconds(_length);

		ObjectToActivate.SetActive (true);
		gameObject.SetActive (false);
	}
}