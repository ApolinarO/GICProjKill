using UnityEngine;
using System.Collections;

public class FirstPersonPlayer : MonoBehaviour {

	public float horizontalLookSpeed = 45;
	public float verticalLookSpeed = 45;
	public Transform myCamera;
	float currentXRotation;
	public float moveSpeed;
	CharacterController controller;
	public float gravity = 30;
	public float jumpSpeed = 40;
	public float sprintSpeed;
	float verticalSpeed;

	// Use this for initialization
	void Start () {
		controller = gameObject.GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (0, Input.GetAxis ("Horizontal") * horizontalLookSpeed * Time.deltaTime, 0);
		currentXRotation += Input.GetAxis ("Vertical") * verticalLookSpeed * -Time.deltaTime;
		currentXRotation = Mathf.Clamp(currentXRotation, -90, 90);
	   myCamera.localRotation = Quaternion.Euler(new Vector3(currentXRotation, 0, 0));

		sprintSpeed = 1;

		if (controller.isGrounded) {
			verticalSpeed = 0;
			if (Input.GetButton ("Jump")) {
				verticalSpeed = jumpSpeed;
			}
			if (Input.GetKey (KeyCode.LeftShift))
				sprintSpeed = 2;


		} else {
			verticalSpeed -= gravity * Time.deltaTime;
		}


		controller.Move (transform.rotation * new Vector3(Input.GetAxis ("HorizontalMove") * moveSpeed * sprintSpeed * Time.deltaTime, verticalSpeed * Time.deltaTime, Input.GetAxis ("VerticalMove") * moveSpeed * sprintSpeed * Time.deltaTime));


	}
}
