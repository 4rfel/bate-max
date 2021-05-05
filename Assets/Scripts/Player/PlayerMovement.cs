using UnityEngine;
using MLAPI;


public class PlayerMovement : NetworkBehaviour {

	InputMaster controls;
	Rigidbody rb;
	[SerializeField] LayerMask Ground;

	float max_foward = 10f;
	float max_backward = 4f;
	float current_acc = 0f;

	bool canMove = true;
	bool isUpsideDown = false;


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
			rot = Quaternion.Euler(new Vector3(0, turnSpeed * 2f, 0f));
		}
	}

	private void Update() {
		if (IsLocalPlayer) {
			TestCanMove();
			TestUpsideDown();
		}
	}

	private void FixedUpdate() {
		if (IsLocalPlayer) {
			//Debug.Log(canMove);
			if (canMove) {
				rb.velocity = rb.velocity + rb.transform.forward * current_acc;
				rb.MoveRotation(rb.rotation * rot);

				if (current_acc > 0f)
					rb.velocity = Vector3.ClampMagnitude(rb.velocity, max_foward);
				else
					rb.velocity = Vector3.ClampMagnitude(rb.velocity, max_backward);
			}
			if (isUpsideDown) {
				transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0f);
				//rb.MoveRotation(rb.rotation * Quaternion.Euler(new Vector3(0f, 0f, 3f)));
			}
		}
	}

	void TestCanMove() {
		if (Physics.Raycast(transform.position, -transform.up, 2f, Ground)) {
			canMove = true;
		} else {
			canMove = false;
		}
	}
	void TestUpsideDown() {
		if (Physics.Raycast(transform.position, transform.up, 2f, Ground)) {
			isUpsideDown = true;
		} else {
			isUpsideDown = false;
		}
	}
}
