using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AudioType{

    None,LinkList, AudioContainer, AudioEffect

}

[CreateAssetMenu(fileName ="SoundObject")]
public class SoundPacketObject : ScriptableObject
{
    [Header("사운드")]
    public List<SoundData> soundData;
}

[System.Serializable]
public class SoundData
{
    [Header("사운드 카테고리 이름")]
    public string name;
    [Header("사운드 타입")]
    public AudioType audioType = AudioType.None;
    [Header("사운드 나열")]
    public List<SoundClip> AudioData;
}

[System.Serializable]
public struct SoundClip
{
    [Header("해당 사운드의 이름")]
    public string name;
    [Header("오디오 클립")]
    public AudioClip audioClip;
}
