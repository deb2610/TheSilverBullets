using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneCall : InteractableScript {
    //variables
    public AnimationClip EmptyAnim;
    public AudioClip clip;
    AudioSource aSource;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        aSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StopAnimation()
    {
        animator.Play(EmptyAnim.name);
    }
    public void StopSound()
    {
        aSource.mute = true;

    }
    public void PlaySound()
    {
        aSource.mute = false;

    }

    void OnMouseDown()
    {
        if (aSource.mute == false)
        {
            StopAnimation();
            StopSound();
        }
        else
        {
            PlayAnimation();
            PlaySound();
        }
        
    }
}
