using UnityEngine;
using MLAPI;
using MLAPI.SceneManagement;

public class MenuButtons : NetworkBehaviour {

	[SerializeField] GameObject buttons;
	[SerializeField] GameObject loading;


	public void Host() {
		NetworkManager.Singleton.StartHost();
		NetworkSceneManager.SwitchScene("Game");
	}

	public void Join() {
		NetworkManager.Singleton.StartClient();
		buttons.SetActive(false);
		loading.SetActive(true);
	}

	InputMaster controls;

	private void Awake() {
		controls = new InputMaster();
		controls.Player.Accelerate.performed += ctx => Accelerate(ctx.ReadValue<float>());
	}

	void Accelerate(float acc) {
		Debug.Log("input " + acc);
	}
}
