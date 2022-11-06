using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AudioType{

    None,LinkList, AudioContainer, AudioEffect

}

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
    [Header("���� Ÿ��")]
    public AudioType audioType = AudioType.None;
    [Header("���� ����")]
    public List<SoundClip> AudioData;
}

[System.Serializable]
public struct SoundClip
{
    [Header("�ش� ������ �̸�")]
    public string name;
    [Header("����� Ŭ��")]
    public AudioClip audioClip;
}
