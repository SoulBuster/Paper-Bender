﻿using UnityEngine;
using System.Collections;

public class DebugScriptA : MonoBehaviour {

	public Transform[] charPosition;
	public GameObject[] cameraEdges;
	CameraMovement cM;
	Transform character;
	PositionDetect pD;
	// Use this for initialization
	void Start () {
		cM = Camera.main.GetComponent<CameraMovement>();
		character = GameObject.FindGameObjectWithTag("Player").transform;
		pD = GameObject.FindGameObjectWithTag("PositionDetect").GetComponent<PositionDetect>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
		{
			character.position = charPosition[0].position;
			Camera.main.GetComponent<CameraMovement>().MoveCamera(pD.cameraPositions[0].x, pD.cameraPositions[0].y, pD.cameraPositions[0].z, false, false);
			for(int i = 0; i < cameraEdges.Length; i++)
			{
				if(i == 1)
				{
					cameraEdges[i].SetActive(true);
				}
				else
				{
					cameraEdges[i].SetActive(false);
				}

			}
		}
		if(Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
		{
			character.position = charPosition[1].position;
			Camera.main.GetComponent<CameraMovement>().MoveCamera(pD.cameraPositions[2].x, pD.cameraPositions[2].y, pD.cameraPositions[3].z, false, false);
			for(int i = 0; i < cameraEdges.Length; i++)
			{
				if(i == 3 || i == 4)
				{
					cameraEdges[i].SetActive(true);
				}
				else
				{
					cameraEdges[i].SetActive(false);
				}
				
			}
		}
		if(Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
		{
			character.position = charPosition[2].position;
			Camera.main.GetComponent<CameraMovement>().MoveCamera(pD.cameraPositions[4].x, pD.cameraPositions[4].y, pD.cameraPositions[4].z, false, false);
			for(int i = 0; i < cameraEdges.Length; i++)
			{
				if(i == 7 || i == 8)
				{
					cameraEdges[i].SetActive(true);
				}
				else
				{
					cameraEdges[i].SetActive(false);
				}
				
			}
		}
	}
}
