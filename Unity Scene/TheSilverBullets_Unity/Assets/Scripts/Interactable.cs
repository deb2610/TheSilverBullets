using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Written by Matt Hoffman
/// Sets an object up to be interactable with the first person controller, plays an animation
/// </summary>
public class Interactable : MonoBehaviour {

    //center is used for position calculations in other scripts
    public Vector3 center;
    //playTime, playing, and pTimer manage how long an animation will play
    public float playTime;
    public bool playing;

    float pTimer;
    Animation anim;

	// Use this for initialization
	void Start () {
        center = transform.position;
        pTimer = playTime;
        //gets the current animation attatched to this object
        anim = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {

        //Counts down play time
        if (playing && pTimer > 0)
        {
            pTimer -= Time.deltaTime;
        }

        //if the timer runs out, stop the animation
        if (pTimer <= 0)
        {
            playing = false;
            pTimer = playTime;
            anim.Stop();
        }
	}

    /// <summary>
    /// Plays the attatched animation on the interactable object
    /// </summary>
    public void StartAnimation()
    {
        playing = true;
        anim.Play();
    }
}
