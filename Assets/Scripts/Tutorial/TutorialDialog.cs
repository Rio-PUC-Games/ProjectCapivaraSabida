﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialDialog : MonoBehaviour {
	private bool _alreadyDisplayedText = false;
	private int _curText = 0;
	private int _numTexts;
	private Transform _textsTransform;

	void Start(){
		_textsTransform = transform.Find ("Texts"); 
		_numTexts = _textsTransform.childCount;
	}

	public void OnTriggerStay2D(Collider2D other){
		//se não for o player, ignore
		if (other.gameObject.tag != "Player") {
			return;
		} 
		if (!_alreadyDisplayedText) {
			ShowText ();
		}
	}

	public void ShowText(){
		gameObject.SetActive (true);
		_alreadyDisplayedText = true;
	}

	public void HideText(){
		if (_curText < _numTexts - 1) {
			_textsTransform.GetChild (_curText).gameObject.SetActive (false);
			_curText++;
			_textsTransform.GetChild (_curText).gameObject.SetActive (true);
		} else {
			gameObject.SetActive (false);
		}
	}
}

