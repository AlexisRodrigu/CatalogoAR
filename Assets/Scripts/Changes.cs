using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changes : MonoBehaviour
{
     GameObject[] objetos;
    public GameObject[] newGO;

    public void ChangeTextos(int objeto)
    {
        objetos = GameObject.FindGameObjectsWithTag("Textos");
        foreach(GameObject obj in objetos)
        {
            obj.SetActive(false);

        }
    }
}
