using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="SoundObject")]
public class SoundPacketObject : ScriptableObject
{
    [Header("����")]
    public List<SoundData> soundData;
}

[System.Serializable]
public class SoundData
{
    [Header("���� ī�װ� �̸�")]
    public string name;
    [Header("���� ����")]
    public List<AudioClip> AudioData;
}
