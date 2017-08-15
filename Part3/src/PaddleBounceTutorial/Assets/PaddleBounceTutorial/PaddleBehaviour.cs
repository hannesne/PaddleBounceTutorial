using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using HoloToolkit.Unity.InputModule;

public class PaddleBehaviour : MonoBehaviour, IInputHandler
{
    public Rigidbody Ball;
    private Vector3 originalBallPosition;
    private Quaternion originalBallRotation;

    public void OnInputDown(InputEventData eventData)
    {
        Ball.useGravity = true;
    }

    public void OnInputUp(InputEventData eventData)
    {
        Ball.useGravity = false;
        Ball.isKinematic = true;
        Ball.transform.SetPositionAndRotation(originalBallPosition, 
            originalBallRotation);
        Ball.isKinematic = false;
    }

    // Use this for initialization
    void Start ()
    {
        originalBallPosition = Ball.transform.position;
        originalBallRotation = Ball.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
