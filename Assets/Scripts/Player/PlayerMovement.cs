using UnityEngine;
using MLAPI;


public class PlayerMovement : NetworkBehaviour {

	InputMaster controls;
	Rigidbody rb;

	float max_foward = 10f;
	float max_backward = 4f;
	float current_acc = 0f;

	Quaternion rot = Quaternion.identity;

	private void Awake() {
		controls = new InputMaster();
		controls.Player.Accelerate.canceled += ctx => Accelerate(ctx.ReadValue<float>());
		controls.Player.Accelerate.performed += ctx => Accelerate(ctx.ReadValue<float>());

		controls.Player.Break.performed += ctx => Break(ctx.ReadValue<float>());
		controls.Player.Break.canceled += ctx => Break(ctx.ReadValue<float>());

		controls.Player.Turn.performed += ctx => Turn(ctx.ReadValue<float>());
		controls.Player.Turn.canceled += ctx => Turn(ctx.ReadValue<float>());
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
		if (IsLocalPlayer) {
			current_acc = acc;
		}
	}

	void Break(float acc) {
		if (IsLocalPlayer) {
			current_acc = -acc;
		}
	}

	void Turn(float turnSpeed) {
		if (IsLocalPlayer) {
			rot = Quaternion.Euler(new Vector3(0, turnSpeed*2f, 0f));
		}
	}

	private void FixedUpdate() {
		if (IsLocalPlayer) {
			rb.velocity = rb.velocity + rb.transform.forward * current_acc;
			rb.MoveRotation(rb.rotation * rot);

			if (current_acc > 0f)
				rb.velocity = Vector3.ClampMagnitude(rb.velocity, max_foward);
			else
				rb.velocity = Vector3.ClampMagnitude(rb.velocity, max_backward);
		}
	}
}
