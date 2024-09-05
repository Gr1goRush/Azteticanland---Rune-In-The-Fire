using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SettingsProvider : MonoBehaviour
{
    public static System.Action<float> OnVolumeChanged;
    public static System.Action<bool> OnMusicStateChanged;

    [SerializeField] private Slider _volumeSlider;

    [SerializeField] private SwitchUI _musicSwitch;
    [SerializeField] private SwitchUI _vibrationSwitch;


    private void Start()
    {
        _volumeSlider.value = Settings.Volume;
        _musicSwitch.SetSwitchVisualState(Settings.MusicEnabled);
        _vibrationSwitch.SetSwitchVisualState(Settings.VibrationEnabled);
    }

    public void SwitchVibroState()
    {
        Settings.VibrationEnabled = !Settings.VibrationEnabled;
    }

    public void SwitchMusicState()
    {
        Settings.MusicEnabled = !Settings.MusicEnabled;
        OnMusicStateChanged?.Invoke(Settings.MusicEnabled);
    }

    public void IncreaseVolume()
    {
        Settings.Volume += 0.1f;
        WorkVolume();
    }

    public void DecreaseVolume()
    {
        Settings.Volume -= 0.1f;
        WorkVolume();
    }

    private void WorkVolume()
    {
        Settings.Volume = Mathf.Clamp(Settings.Volume, 0, 1);
        _volumeSlider.value = Settings.Volume;
        OnVolumeChanged?.Invoke(Settings.Volume);
    }

    public void SetPauseState(bool state)
    {
        Settings.GameIsPaused = state;
    }
}
