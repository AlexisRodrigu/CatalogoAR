using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField] private Light directionalLight;
    [SerializeField] private EdecanController edecanControllerScript;
    [SerializeField] private GameObject[] lights;
    private Animator animator;
    readonly int animLightEnabled = Animator.StringToHash("Enabled");

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        TurnLights();
    }
    ///Prendiendo y apagando las luces
    void TurnLights()
    {
        if (edecanControllerScript.Dancing == true)
        {
            directionalLight.enabled = false;
            animator.SetBool(animLightEnabled, true);
            foreach (GameObject lightGO in lights)
            {
                lightGO.GetComponent<Light>().enabled = true;
            }
        }
        else
        {
            directionalLight.enabled = true;
            animator.SetBool(animLightEnabled, false);
            foreach (GameObject lightGO in lights)
            {
                lightGO.GetComponent<Light>().enabled = false;
            }
        }
    }

}
