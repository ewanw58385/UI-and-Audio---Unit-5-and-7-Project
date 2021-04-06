using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    public void SliderChanged()
    {
        float value = GetComponent<Slider>().value;   
        print("slider=" + value);

        PlayerPrefs.SetFloat("musicvolume",value);

        AudioManager.instance.SetVolume("soundtrack", value);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
