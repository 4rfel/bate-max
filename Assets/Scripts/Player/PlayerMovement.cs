using UnityEngine;
using MLAPI;
using MilkShake;
using MLAPI.NetworkVariable;


public class PlayerMovement : NetworkBehaviour {

	InputMaster controls;
	Rigidbody rb;
	[SerializeField] LayerMask Ground;
	[SerializeField] GameObject nitroObj;
	[SerializeField] Material nitroMaterial;
	[SerializeField] GameObject cart;

	NetworkVariable<Color> color = new NetworkVariable<Color>(new NetworkVariableSettings { WritePermission = NetworkVariablePermission.OwnerOnly }, Color.black);


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

	[SerializeField]
	Shaker shaker;

	[SerializeField]
	ShakePreset shake_preset;


	PausePlayer pausePlayer;
	bool flag_inutil = false;

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
			nitroObj.SetActive(true);
			rb = GetComponent<Rigidbody>();
			pausePlayer = GetComponent<PausePlayer>();
			Color c = new Color(Random.Range(0.2f, 0.9f), Random.Range(0.2f, 0.9f), Random.Range(0.2f, 0.9f));
			color.Value = c;
		}
		Material cartMaterial = cart.GetComponent<Renderer>().material;

		cartMaterial.SetColor("_Color", color.Value);
		cartMaterial.SetColor("_AmbientLight", color.Value * 0.5f);
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
			if (pausePlayer.paused)
				return;
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
				nitroMaterial.SetFloat("_Hp", (nitroDuration - nitroCurrentDuration) / nitroDuration);
			} else {
				if (nitroCurrentCD > 0f) {
					nitroCurrentCD -= Time.deltaTime;
				}
				nitroMaterial.SetFloat("_Hp", (nitroCD - nitroCurrentCD) / nitroCD);
			}

			if (transform.position.y < -20f) {
				transform.position = Vector3.zero;
				rb.velocity = Vector3.zero;
				transform.rotation = Quaternion.Euler(0f, 0f, 0f);
			}
		} else {
			if (color.Value == Color.black) {
				flag_inutil = true;
			}
			if (flag_inutil && color.Value != Color.black) {
				Material cartMaterial = cart.GetComponent<Renderer>().material;
				cartMaterial.SetColor("_Color", color.Value);
				cartMaterial.SetColor("_AmbientLight", color.Value * 0.5f);
				flag_inutil = false;
			}
		}

	}

	private void FixedUpdate() {
		if (IsLocalPlayer) {
			if (rb.velocity.magnitude > max_foward) {
				rb.velocity = rb.velocity - rb.velocity * nitroDisacceleration;
			}


			if (canMove) {

				rb.MoveRotation(rb.rotation * rot);

				rb.velocity = Vector3.ClampMagnitude(rb.velocity, max_foward);

				if (current_acc > 0f) {
					if (rb.velocity.magnitude > max_foward) {
						current_acc = 1f;
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
			}
		}
	}

	void TestCanMove() {
		if (pausePlayer.paused) {
			canMove = false;
			return;
		}
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

	private void OnCollisionEnter(Collision other) {
		if (other.gameObject.name == this.gameObject.name) {
			Debug.Log("aaaaaaaaaa");
			Sound.PlaySound("crash");
			shaker.Shake(shake_preset);
		}
	}

}


