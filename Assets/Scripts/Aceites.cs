using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Aceites : MonoBehaviour
{
    public GameObject aceiteGO;
    public Slider slider;

    public Material[] newColor;
    GameObject[] objeto;
    Material[] mats;


    public void Rotate()
    {
        aceiteGO.transform.rotation = Quaternion.Euler(0, slider.value, 0);
    }

    public void ChangeColor(int color)
    {
        objeto = GameObject.FindGameObjectsWithTag("Colorear");
        foreach (GameObject obj in objeto)
        {
            mats = obj.GetComponent<Renderer>().materials;
            mats[0] = newColor[color];
            obj.GetComponent<Renderer>().materials = mats;
        }
        objeto = null;
    }
}
   
