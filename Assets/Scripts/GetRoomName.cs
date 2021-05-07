using UnityEngine;
using UnityEngine.UI;
using MLAPI;

public class GetRoomName : MonoBehaviour {

	[SerializeField] Text txt;

	MLAPI.Transports.PhotonRealtime.PhotonRealtimeTransport transport;

	private void Start() {
		transport = GameObject.FindGameObjectWithTag("NetworkManager").GetComponent<MLAPI.Transports.PhotonRealtime.PhotonRealtimeTransport>();
	}

	void Update() {
		if (transport != null)
			txt.text = transport.RoomName;
		else
			transport = GameObject.FindGameObjectWithTag("NetworkManager").GetComponent<MLAPI.Transports.PhotonRealtime.PhotonRealtimeTransport>();
	}
}
