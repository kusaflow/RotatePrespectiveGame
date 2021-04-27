using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraZoomHandler : MonoBehaviour
{
    public Slider slider;
    public Camera cam;

    private void Start()
    {
        slider.value = 60;
    }

    // Update is called once per frame
    void Update()
    {
        cam.fieldOfView = slider.value;
    }
}
