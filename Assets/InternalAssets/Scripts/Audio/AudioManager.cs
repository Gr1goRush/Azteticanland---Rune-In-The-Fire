using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [SerializeField, HideInInspector] private AudioSource _source;

    private void OnValidate()
    {
        _source ??= GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        SettingsProvider.OnVolumeChanged += ChangeVolume;
    }

    private void OnDisable()
    {
        SettingsProvider.OnVolumeChanged -= ChangeVolume;
    }

    private void Start()
    {
        instance = this;
        _source.volume = Settings.Volume;
    }

    public void PlayClip(AudioClip clip)
    {
        if (Settings.SoundsEnabled)
        {
            _source.PlayOneShot(clip);
        }
    }

    public void ChangeVolume(float value)
    {
        _source.volume = value;
    }
}
