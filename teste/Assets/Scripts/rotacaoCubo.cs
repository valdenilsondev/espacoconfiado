﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacaoCubo : MonoBehaviour {


	public Transform rotacaoCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.rotation = Quaternion.Euler(0, rotacaoCamera.rotation.y, 0);
	}
}
