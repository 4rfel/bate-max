using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

public class CameraController : NetworkBehaviour {
	[SerializeField] GameObject fistPerson;
	[SerializeField] GameObject thirdPerson;

	bool isFirstPerson = true;

	void Start() {
		fistPerson.SetActive(false);
		thirdPerson.SetActive(false);
		if (IsLocalPlayer) {
			fistPerson.SetActive(isFirstPerson);
		}
	}

	void Update() {
		if (IsLocalPlayer) {
			if (Input.GetButtonDown("ChangeCam")) {
				ChangeCam();
			}
		}
	}

	void ChangeCam() {
		isFirstPerson = !isFirstPerson;
		fistPerson.SetActive(isFirstPerson);
		thirdPerson.SetActive(!isFirstPerson);
	}
}
