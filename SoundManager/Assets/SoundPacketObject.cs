using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    [Header("사운드 나열")]
    public List<AudioClip> AudioData;
}
