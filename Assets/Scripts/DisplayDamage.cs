using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas damageCanvas;
    [SerializeField] float time = 0.3f;

    void Start()
    {
        damageCanvas.enabled = false;
    }

    public void ShowDamageImpact()
    {
        StartCoroutine(damageTaken());
    }

    IEnumerator damageTaken()
    {
        damageCanvas.enabled = true;
        yield return new WaitForSeconds(time);
        damageCanvas.enabled = false;


    }
}
