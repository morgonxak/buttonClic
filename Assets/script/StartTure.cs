﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartTure : MonoBehaviour, IPointerClickHandler
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnPointerClick(PointerEventData data)
    {
        Debug.Log("Load Test");
        SceneManager.LoadScene("test");
    }
}
