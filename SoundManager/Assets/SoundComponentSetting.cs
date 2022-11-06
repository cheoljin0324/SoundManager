using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundComponentSetting : MonoBehaviour
{
    void SoundActiveSetting(SoundData packet)
    {
        switch (packet.audioType) 
        {
            case AudioType.None:
                break;
            case AudioType.AudioContainer:
                AudioContainerSetting();
                break;
            case AudioType.AudioEffect:
                AudioEffectSetting();
                break;
            case AudioType.LinkList:
                AudioListSetting();
                break;
            default:
                    break;
        }

    }

    void AudioContainerSetting()
    {
        GameObject audioContainer = new GameObject("AudioContainer");
        audioContainer = Instantiate(audioContainer);

        audioContainer.AddComponent<AudioContainer>();
    }

    void AudioEffectSetting()
    {
        GameObject audioContainer = new GameObject("AudioEffect");
        audioContainer = Instantiate(audioContainer);

        audioContainer.AddComponent<AudioEffect>();
    }

    void AudioListSetting()
    {
        GameObject audioContainer = new GameObject("AudioList");
        audioContainer = Instantiate(audioContainer);

        audioContainer.AddComponent<AudioList>();
    }
}
