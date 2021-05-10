using UnityEngine;
using MLAPI;
using UnityEngine.UI;

public class bg_music : NetworkBehaviour {

    AudioSource _audio;
    public Slider audio_value;

    private void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start() {
        _audio = GetComponent<AudioSource>();
    }

    private void Update() {
        if (audio_value == null) _audio.volume = 1f;
        else _audio.volume = audio_value.value;
    }

}