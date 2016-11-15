using UnityEngine;
using System.Collections;

public class CameraTriggerClass : MonoBehaviour {
	//public GameObject camToActivate;
	public int camNumber;

	public NewBehaviourScript controller;

	void OnTriggerEnter(Collider other){

		controller.DeactivateCameras();
		controller.activateCamera(camNumber);

	}
}
