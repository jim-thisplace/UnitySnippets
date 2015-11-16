using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

	public GameObject crosshair;
	public bool isVR = false;

	float camPitch = 0;
	public float cameraPitchRange = 80.0f;
	float mouseSensitivity = 3.0f;

	GameObject GetObjectUnderCrosshair ()
	{

		RaycastHit hit;
		// Trace ray from MainCamera through the reticle
		Ray ray = new Ray (Camera.main.transform.position, crosshair.transform.position - Camera.main.transform.position);

		if (Physics.Raycast (ray, out hit)) {
			GameObject hitObject = hit.collider.gameObject;
			return hitObject;
		}

		return null;
	}

	void Start() {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void UpdatePlayerRotation ()
	{
		float yaw;

		if (isVR == false) {
			yaw = Input.GetAxis ("Mouse X") * mouseSensitivity;
			camPitch -= Input.GetAxis ("Mouse Y") * mouseSensitivity;
			camPitch = Mathf.Clamp (camPitch, -cameraPitchRange, cameraPitchRange);

			// Player yaw
			transform.Rotate (0, yaw, 0);

			// Player camera pitch
			Camera.main.transform.localRotation = Quaternion.Euler (camPitch, 0, 0);
		}
	}

	void Update ()
	{
		UpdatePlayerRotation ();

		GameObject target = GetObjectUnderCrosshair ();
		if (target != null) {

			//GetComponent<AudioSource> ().Play ();
		}
	}
}