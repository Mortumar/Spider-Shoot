using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float restoreAngle = 20f;
    [SerializeField] float intensityAmount = 2f;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponentInChildren<FlashLight>().ResoreLightAngle(restoreAngle);
            other.GetComponentInChildren<FlashLight>().RestoreLightIntensity(intensityAmount);
            Destroy(gameObject);
        }
    }
}
