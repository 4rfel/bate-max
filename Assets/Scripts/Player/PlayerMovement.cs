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

	bool isNitro = false;
	float nitroDuration = 3f;
	float nitroCurrentDuration = 0f;
	float nitroCD = 5f;
	float nitroCurrentCD = 0f;
	float nitroAcceleration = 10f;
	float nitroDisacceleration = 0.01f;
	float maxNitroSpeed = 30f;


	Quaternion rot = Quaternion.identity;

	private void Awake() {
		controls = new InputMaster();
		controls.Player.Accelerate.canceled += ctx => Accelerate(ctx.ReadValue<float>());
		controls.Player.Accelerate.performed += ctx => Accelerate(ctx.ReadValue<float>());

		controls.Player.Break.performed += ctx => Break(ctx.ReadValue<float>());
		controls.Player.Break.canceled += ctx => Break(ctx.ReadValue<float>());

		controls.Player.Turn.performed += ctx => Turn(ctx.ReadValue<float>());
		controls.Player.Turn.canceled += ctx => Turn(ctx.ReadValue<float>());

		controls.Player.Nitro.performed += ctx => Nitro();
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

	void Nitro() {
		if (IsLocalPlayer) {
			if (nitroCurrentCD <= 0f) {
				isNitro = true;
				nitroCurrentCD = nitroCD;
			}
		}
	}

	private void Update() {
		if (IsLocalPlayer) {
			TestCanMove();
			TestUpsideDown();
			if (isNitro) {

				if (nitroCurrentDuration < nitroDuration) {
					nitroCurrentDuration += Time.deltaTime;
				} else {
					isNitro = false;
					nitroCurrentDuration = 0f;
				}
			} else {
				if (nitroCurrentCD > 0f) {
					nitroCurrentCD -= Time.deltaTime;
				}
			}
		}
	}
	public float k = 0f;
	private void FixedUpdate() {
		if (IsLocalPlayer) {
			if (rb.velocity.magnitude > max_foward) {
				rb.velocity = rb.velocity - rb.velocity * nitroDisacceleration;
			}


			if (canMove) {

				rb.MoveRotation(rb.rotation * rot);

				if (current_acc > 0f) {
					if (rb.velocity.magnitude > max_foward) {
						current_acc = 0f;
					}
				} else if (current_acc < 0f) {
					if (rb.velocity.magnitude > max_backward) {
						current_acc = 0f;
					}
				}

				rb.velocity = rb.velocity + rb.transform.forward * current_acc;


				if (isNitro) {
					rb.velocity = rb.velocity + rb.transform.forward * nitroAcceleration;
					rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxNitroSpeed);
				}

			}
			if (isUpsideDown) {
				transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0f);
				//rb.MoveRotation(rb.rotation * Quaternion.Euler(new Vector3(0f, 0f, k)));
			}
		}
	}

	void TestCanMove() {
		//Debug.Log(transform.TransformPoint(transform.position)/2);
		//Debug.DrawLine(transform.TransformPoint(transform.position)/2, transform.TransformPoint(-transform.up)/2 );
		if (Physics.Raycast(transform.position, -transform.up, 1f, Ground)) {
			canMove = true;
		} else {
			canMove = false;
		}
	}

	void TestUpsideDown() {
		if (Physics.Raycast(transform.position, transform.up, 0.7f, Ground)) {
			isUpsideDown = true;
		} else {
			isUpsideDown = false;
		}
	}
}
