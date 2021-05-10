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
		float cameraRotationX = map(mp.x, 0 + sensy.value, 1070 - sensy.value, 0, 360);
		cameraRotationX += 180;
		aa.transform.rotation = transform.rotation * Quaternion.Euler(0f, cameraRotationX, 0f);

	}

	void MoveCameraFP() {
		Vector2 mp = Mouse.current.position.ReadValue();
		float cameraRotationX = Mathf.Clamp(mp.x, sensy.value, 1070 - sensy.value);
		cameraRotationX = map(cameraRotationX, 0 + sensy.value, 1070 - sensy.value, -90, 90);
		cam.transform.rotation = transform.rotation * Quaternion.Euler(0f, cameraRotationX, 0f);
	}

	float map(float s, float a1, float a2, float b1, float b2) {
		return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
	}
}
