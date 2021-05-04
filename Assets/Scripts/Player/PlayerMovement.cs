using UnityEngine;
using MLAPI;


public class PlayerMovement : NetworkBehaviour {

	InputMaster controls;
	Rigidbody rb;
	const float multiplier = 2f;

	float max_foward = 2;
	float max_backward = 0.5f;
	float turnSpeed = 2f;



	Vector3 dir = Vector3.zero;
	Quaternion rot = Quaternion.identity;

	private void Awake() {
		controls = new InputMaster();
		controls.Player.Accelerate.performed += ctx => Accelerate(ctx.ReadValue<float>());
		controls.Player.Break.performed += ctx => Break(ctx.ReadValue<float>());
		controls.Player.Turn.performed += ctx => Turn(ctx.ReadValue<float>());
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
			dir = Vector3.forward * acc * multiplier;
		}
	}

	void Break(float acc) {
		if (IsLocalPlayer) {
			dir = -Vector3.forward * acc * multiplier;
		}
	}

	void Turn(float turnSpeed) {
		if (IsLocalPlayer) {
			rot = Quaternion.Euler(new Vector3(0, turnSpeed, 0f));
		}
	}

	private void FixedUpdate() {
		if (IsLocalPlayer) {
			rb.AddForce(dir);
            rb.MoveRotation(rb.rotation * rot);
			
			rb.velocity = rb.velocity.magnitude * rb.transform.forward * dir.z;

			if (dir.magnitude > 0f)
				rb.velocity = Vector3.ClampMagnitude(rb.velocity, max_foward);
			else
				rb.velocity = Vector3.ClampMagnitude(rb.velocity, max_backward);
		}
	}
}
