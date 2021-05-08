using UnityEngine;
using UnityEngine.SceneManagement;
using MLAPI;
using MLAPI.Messaging;

public class PausePlayer : NetworkBehaviour {

	InputMaster controls;

	[SerializeField] GameObject pauseCanvas;
	public bool paused = false;

	private void Awake() {
		controls = new InputMaster();

		controls.Player.Pause.performed += ctx => Pause();
	}

	private void Start() {
		if (IsLocalPlayer) {
			Cursor.visible = false;
		}
	}

	private void OnEnable() {
		controls.Enable();
	}

	private void OnDisable() {
		controls.Disable();
	}

	public void Pause() {
		if (IsLocalPlayer) {
			paused = !paused;
			pauseCanvas.SetActive(paused);
			Cursor.visible = paused;

		}
	}

	public void StopGame() {
		if (IsHost) {
			StopHostClientRpc();
			NetworkManager.Singleton.StopHost();
		} else
			NetworkManager.Singleton.StopClient();
	}

	[ClientRpc]
	void StopHostClientRpc() {
		Debug.Log("AAA");
		Application.Quit();
		//NetworkManager.Singleton.StopClient();
		//SceneManager.LoadScene("Game");
	}

	public void ToMenu() {
		if (IsLocalPlayer) {
			StopGame();
			SceneManager.LoadScene("Game");
		}
	}

	public void Quit() {
		if (IsLocalPlayer) {
			StopGame();
			Application.Quit();
		}
	}
}
