using UnityEngine;
using MLAPI;

public class Sound : NetworkBehaviour {

    public static AudioClip crash;
    static AudioSource audioSource;

    // ----------------------- 

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
        crash = Resources.Load<AudioClip>("Sounds/crash");
    }

    private void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }

    public static void PlaySound(string clip){
        switch (clip){
            case "crash":
                audioSource.PlayOneShot(crash);
                break;
            
        }
    }
}