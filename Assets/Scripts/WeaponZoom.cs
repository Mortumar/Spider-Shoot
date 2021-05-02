using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomedView = 20f;
    [SerializeField] float regularView = 48f;
    [SerializeField] float zoomedSensitivity = 1f;
    [SerializeField] float regularSensitivity = 2f;



   bool zoomedInToggle = false;
    private void OnDisable()
    {
        ZoomOut();
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false)
            {
                ZoomIN();
            }
            else
            {
                ZoomOut();
            }
        }
    }

    private void ZoomOut()
    {
        zoomedInToggle = false;
        fpsCamera.fieldOfView = regularView;
        fpsController.mouseLook.XSensitivity = regularSensitivity;
        fpsController.mouseLook.YSensitivity = regularSensitivity;
    }

    private void ZoomIN()
    {
        zoomedInToggle = true;
        fpsCamera.fieldOfView = zoomedView;
        fpsController.mouseLook.XSensitivity = zoomedSensitivity;
        fpsController.mouseLook.YSensitivity = zoomedSensitivity;
    }

   
}
