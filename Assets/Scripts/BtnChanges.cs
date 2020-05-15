using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnChanges : MonoBehaviour
{
    public void AceiteMotor()
    {
        SceneManager.LoadScene(1);
    }
    public void ATF()
    {
        SceneManager.LoadScene(2);
    }
    public void CVTF()
    {
        SceneManager.LoadScene(3);
    }
    public void PSF()
    {
        SceneManager.LoadScene(4);
    }
    public void Return()
    {
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
