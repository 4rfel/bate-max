using UnityEngine;
using MLAPI;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class CameraController : NetworkBehaviour {
	[SerializeField] GameObject fistPerson;
	[SerializeField] GameObject thirdPerson;
	[SerializeField] GameObject cam;
	[SerializeField] GameObject aa;
	[SerializeField] Slider sensy;



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
			if (isFirstPerson) {
				cam.transform.rotation = Quaternion.Euler(0f, 0f, 0f) * transform.rotation;
				cam.transform.position = fistPerson.transform.position;

			} else {
				cam.transform.rotation = Quaternion.Euler(0f, 0f, 0f) * transform.rotation;
				cam.transform.position = thirdPerson.transform.position;
			}
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

		Vector2 mp = Mouse.current.position.ReadValue();
		float cameraRotationX = mp.x * sensy.value;

		aa.transform.rotation = Quaternion.Euler(0f, cameraRotationX, 0f);
		Debug.Log(cameraRotationX);

	}

	void MoveCameraFP() {
		Vector2 mp = Mouse.current.position.ReadValue();
		float cameraRotationX = mp.x * sensy.value;
		cameraRotationX = Mathf.Clamp(cameraRotationX, -90, 90);
		cam.transform.rotation = Quaternion.Euler(0f, cameraRotationX, 0f) * transform.rotation;
	}
}
