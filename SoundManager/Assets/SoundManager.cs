using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioClip[] ClipList;

    // Start is called before the first frame update
    void Start()
    {
        ClipList = FindObjectsOfType<AudioClip>();
    }
}
