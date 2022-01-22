using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera FPScamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomOutFOV = 60f;
    [SerializeField] float zoomInFOV = 20f;
    [SerializeField] float zoomOutSensitivity = 2;
    [SerializeField] float zoomInSensitivity = .5f;

    bool zoomInToggle = false;

    private void OnDisable()
    {
        zoomOut();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(zoomInToggle == false)
            {
                zoomIn();
            }
            else
            {
                zoomOut();
            }
        }
    }

    private void zoomOut()
    {
        zoomInToggle = false;
        FPScamera.fieldOfView = zoomOutFOV;
        fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
        fpsController.mouseLook.YSensitivity = zoomOutSensitivity;
    }

    private void zoomIn()
    {
        zoomInToggle = true;
        FPScamera.fieldOfView = zoomInFOV;
        fpsController.mouseLook.XSensitivity = zoomInSensitivity;
        fpsController.mouseLook.YSensitivity = zoomInSensitivity;
    }
}
