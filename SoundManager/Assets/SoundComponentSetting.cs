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
                return;
                break;
            case AudioType.AudioContainer:
                AudioContainerSetting(packet);
                break;
            case AudioType.AudioEffect:
                AudioEffectSetting(packet);
                break;
            case AudioType.LinkList:
                AudioListSetting(packet);
                break;
            default:
                return;
                    break;
        }

    }

    void AudioContainerSetting(SoundData packet)
    {
        GameObject audioContainer = new GameObject("AudioContainer");
        audioContainer = Instantiate(audioContainer);

        audioContainer.AddComponent<AudioContainer>();
    }

    void AudioEffectSetting(SoundData packet)
    {

    }

    void AudioListSetting(SoundData packet)
    {

    }
}
