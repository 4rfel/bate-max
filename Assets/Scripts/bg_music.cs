using UnityEngine;
using MLAPI;

public class bg_music : NetworkBehaviour {
    private void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }
}