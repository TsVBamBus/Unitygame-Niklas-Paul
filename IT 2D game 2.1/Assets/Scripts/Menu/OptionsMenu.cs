using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    //Toggle Button ob Fullscreen an ist oder aus
    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

}
