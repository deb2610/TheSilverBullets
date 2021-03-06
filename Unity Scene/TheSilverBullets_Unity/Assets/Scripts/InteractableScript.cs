﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableScript : MonoBehaviour {

	public AnimationClip anim;
	public Animator animator;
	public Material outlineMat;
	public Material defaultMat;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayAnimation()
	{
		animator.Play(anim.name);
	}

	void  OnMouseDown()
	{
		PlayAnimation();
	}

	private void OnMouseEnter()
	{
		GetComponentInChildren<Renderer>().material = outlineMat;
	}

	private void OnMouseExit()
	{
		GetComponentInChildren<Renderer>().material = defaultMat;
	}
}
