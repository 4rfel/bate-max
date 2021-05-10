using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volume_atributor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("bg").GetComponent<bg_music>().audio_value = GetComponent<Slider>();
        GameObject.FindGameObjectWithTag("sfx").GetComponent<Sound>().audio_value = GetComponent<Slider>();
    }
}
