using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdecanController : MonoBehaviour
{
    private Animator anim;
    public GameObject aceite;
    [SerializeField] private bool dancing = false;
    private string[] names = new string[3] { "DanceOne", "DanceTwo", "DanceThree" };

    private string clipName;
    private AnimatorClipInfo[] clipInfo;
    private float clipDuration;
    private string idle = "Idle";
    //Musica
    private AudioSource audioS;
    public AudioClip[] otherClip;
    private bool puedesTocar;

    public bool Dancing { get => dancing; }

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
        Tocando();
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
    void Tocando()
    {
        if (puedesTocar == true)
        {
            audioS.clip = otherClip[Random.Range(0, 4)];
            audioS.Play();
            Debug.Log(puedesTocar);
        }
    }
}


