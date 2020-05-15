using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdecanController : MonoBehaviour
{
    Animator anim;
    public GameObject aceite;
   [SerializeField] bool dancing = false;
    string[] names = new string[3] { "DanceOne", "DanceTwo", "DanceThree" };


    string clipName;
    AnimatorClipInfo[] clipInfo;
    float clipDuration;
    string idle = "Idle";

    //Musica
    public AudioClip[] otherClip;
    AudioSource audioS;
    bool puedesTocar;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
       audioS = GetComponent<AudioSource>();
    }
    public void Update()
    {
        Comprobar();
    }

    private void OnMouseDown()
    {
        puedesTocar = true;
        
       anim.SetTrigger(names[Random.Range(0, 3)]);
      
        Com();
    }

    void Comprobar()
    {
        clipInfo = this.anim.GetCurrentAnimatorClipInfo(0);
        clipDuration = clipInfo[0].clip.length;
        clipName = clipInfo[0].clip.name;

        if (clipName == idle)
        {
            dancing = false;
            aceite.SetActive(true);
          
        }
        else
        {
            dancing = true;
            aceite.SetActive(false);
        }
    }
    void Com()
    {
        if (puedesTocar == true)
        {
          
            audioS.clip = otherClip[Random.Range(0, 4)];
            audioS.Play();
            Debug.Log(puedesTocar);
        }
    }
}


