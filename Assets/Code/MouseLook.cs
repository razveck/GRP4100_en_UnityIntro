using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityIntro {
	public class MouseLook : MonoBehaviour {

		private float _cameraXRotation;

		//attribute
		[SerializeField] //allows the Unity EDITOR to display and change the following field
		private Transform _camera;


		// Update is called once per frame
		private void Update() {
			if(Pause.IsPaused)
				return;

			float mouseX = Input.GetAxisRaw("Mouse X");
			transform.Rotate(new Vector3(0f, mouseX, 0f));

			float mouseY = Input.GetAxisRaw("Mouse Y");
			_cameraXRotation -= mouseY;
			_cameraXRotation = Mathf.Clamp(_cameraXRotation, -90, 90);
			_camera.localRotation = Quaternion.Euler(_cameraXRotation, 0f, 0f);
		}
	}
}
