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
}
