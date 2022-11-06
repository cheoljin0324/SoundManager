using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioContainer : MonoBehaviour
{

    public List<AudioContainer> audioContainer;
    public SoundManager soundManager;

    private void Awake()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]
public class AudioContainerBase
{
    string audioName;
    AudioClip audioClip;
    
}
