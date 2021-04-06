using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioToggle : MonoBehaviour
{
    public void PlayStartSound()
    {
    AudioManager.instance.Play("StartClickEdited", 1f);
    }


    public void PlayGeneralNavSound()
    {
    AudioManager.instance.Play("ClickEdited", 1f);
    }


    public void PlayBackSound()
    {
    AudioManager.instance.Play("BackClickEdited", 1f);
    }
}
