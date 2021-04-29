using UnityEngine;
using MLAPI;

public class CameraController : NetworkBehaviour {
	[SerializeField] GameObject fistPerson;
	[SerializeField] GameObject thirdPerson;

	bool isFirstPerson = true;

	InputMaster controls;


	private void Awake() {
		controls = new InputMaster();
		controls.Player.ChangeCam.performed += ctx => ChangeCam();
	}

	private void OnEnable() {
		controls.Enable();
	}

	private void OnDisable() {
		controls.Disable();
	}

	void Start() {
		fistPerson.SetActive(false);
		thirdPerson.SetActive(false);
		if (IsLocalPlayer) {
			fistPerson.SetActive(isFirstPerson);
		}
	}

	void ChangeCam() {
		if (IsLocalPlayer) {
			isFirstPerson = !isFirstPerson;
			fistPerson.SetActive(isFirstPerson);
			thirdPerson.SetActive(!isFirstPerson);
		}
	}


}
