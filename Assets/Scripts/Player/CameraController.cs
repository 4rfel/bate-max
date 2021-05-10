using UnityEngine;
using MLAPI;

public class CameraController : NetworkBehaviour {
	[SerializeField] GameObject fistPerson;
	[SerializeField] GameObject thirdPerson;
	[SerializeField] GameObject cam;

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
		cam.SetActive(false);
		if (IsLocalPlayer) {
			cam.SetActive(true);
			cam.transform.position = fistPerson.transform.position;
		}
	}

	void ChangeCam() {
		if (IsLocalPlayer) {
			isFirstPerson = !isFirstPerson;
			if (isFirstPerson)
				cam.transform.position = fistPerson.transform.position;
			else
				cam.transform.position = thirdPerson.transform.position;
		}
	}

	private void LateUpdate() {
		if (IsLocalPlayer) {
			if (isFirstPerson)
				MoveCameraFP();
			else
				MoveCameraTP();
		}
	}

	void MoveCameraTP() {

	}

	void MoveCameraFP() {

	}

}
