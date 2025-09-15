using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEg : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        // Play the audio clip as soon as the script starts
        source.PlayOneShot(clip);
    }
}
