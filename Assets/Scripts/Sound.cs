using UnityEngine;
using UnityEngine.UI;
using MLAPI;

public class Sound : NetworkBehaviour {

    public static AudioClip crash;
    static AudioSource audioSource;
    public Slider audio_value;

    // ----------------------- 

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
        crash = Resources.Load<AudioClip>("Sound/crash");
    }

    private void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update() {
        if (audio_value == null) audioSource.volume = 1f;
        else audioSource.volume = audio_value.value;
    }

    public static void PlaySound(string clip){
        switch (clip){
            case "crash":
                audioSource.PlayOneShot(crash);
                break;
            
        }
    }
}