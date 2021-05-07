using UnityEngine;
using MLAPI;
using UnityEngine.UI;


public class MenuRoomName : NetworkBehaviour {

	[SerializeField] InputField roomName;
	MLAPI.Transports.PhotonRealtime.PhotonRealtimeTransport transport;
	
	private void Start() {
		transport = GameObject.FindGameObjectWithTag("NetworkManager").GetComponent<MLAPI.Transports.PhotonRealtime.PhotonRealtimeTransport>();
	}

	void Update() {
		if (roomName.text.Length == 6) {
			transport.RoomName = roomName.text.ToUpper();
		}
	}
}
