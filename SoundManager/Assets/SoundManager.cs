using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public SoundPacketObject ClipList;
    public AudioClipBase[] audioClipBases;

    // Start is called before the first frame update
    void Start()
    {
        ClipList = FindObjectOfType<SoundPacketObject>();
        audioClipBases = FindObjectsOfType<AudioClipBase>();
    }

    void AudioClipSetting()
    {
        for(int i = 0;i <ClipList.soundData.Count; i++)
        {
            for(int j = 0; j<audioClipBases.Length; i++)
            {
                if(audioClipBases[j].clipBaseName == ClipList.soundData[i].name)
                {
                    audioClipBases[j].audioBase = ClipList.soundData[i].AudioData;
                }
            }
        }
    }
    


}
