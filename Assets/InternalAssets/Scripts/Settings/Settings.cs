using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public static bool MusicEnabled = true;
    public static bool SoundsEnabled = true;
    public static bool VibrationEnabled = true;
    public static bool GameIsPaused;
    public static float Volume = 1;

}


public class DeviceHelper
{
    public static void PlayVibration()
    {
        if (Settings.VibrationEnabled)
        {
            Handheld.Vibrate();
        }
    }
}
