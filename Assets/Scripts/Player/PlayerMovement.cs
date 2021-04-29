using UnityEngine;
using MLAPI;


public class PlayerMovement : NetworkBehaviour {

	InputMaster controls;
	Rigidbody rb;

	public float max = 10;

	private void Awake() {
		controls = new InputMaster();
		controls.Player.Accelerate.performed += ctx => Accelerate(ctx.ReadValue<float>());
		controls.Player.Break.performed += ctx => Break(ctx.ReadValue<float>());

	}

	private void Start() {
		if (IsLocalPlayer) {
			rb = GetComponent<Rigidbody>();
		}
	}

	private void OnEnable() {
		controls.Enable();
	}

	private void OnDisable() {
		controls.Disable();
	}

	void Accelerate(float acc) {
		Debug.Log("acc" + acc);
		//if (IsLocalPlayer) {
		//	rb.AddForce(Vector3.forward * acc * 100);
		//	rb.velocity = Vector3.ClampMagnitude(rb.velocity, max);
		//}
	}

	void Break(float acc) {
		Debug.Log("break" + acc);

		//if (IsLocalPlayer) {
		//	rb.AddForce(-Vector3.forward * acc * 100);
		//	rb.velocity = Vector3.ClampMagnitude(rb.velocity, -max/4);
		//}
	}
}
