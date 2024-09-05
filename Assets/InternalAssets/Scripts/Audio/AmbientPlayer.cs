using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AmbientPlayer : MonoBehaviour
{
    [SerializeField, HideInInspector] private AudioSource _source;

    private void OnValidate()
    {
        _source ??= GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        SettingsProvider.OnVolumeChanged += ChangeVolume;
        SettingsProvider.OnMusicStateChanged += MuteSource;
    }

    private void OnDisable()
    {
        SettingsProvider.OnVolumeChanged -= ChangeVolume;
        SettingsProvider.OnMusicStateChanged -= MuteSource;
    }

    private void Start()
    {
        _source.mute = !Settings.MusicEnabled;
        _source.volume = Settings.Volume;
    }

    public void ChangeVolume(float value)
    {
        _source.volume = value;
    }

    public void MuteSource(bool state)
    {
        _source.mute = !state;
    }
}
