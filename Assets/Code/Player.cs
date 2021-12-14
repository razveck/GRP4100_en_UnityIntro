using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityIntro {
	public class Player : MonoBehaviour {

		public float Speed = 1;


		public Enemy MyEnemy;

		public Rigidbody Rb;


		public float Horizontal;
		public float Vertical;

		public KeyCode JumpKey;

		// Start is called before the first frame update
		private void Start() {
			Debug.Log("The Player is alive!");

			Debug.Log($"{MyEnemy.gameObject.name} has {MyEnemy.Health} HP");

			Rb = GetComponent<Rigidbody>();
		}


		// Update is called once per frame
		private void Update() {
			//transform.Translate(0, 1, 0);
			//transform.position = new Vector3(5, 6, 9.1f);

			//old (legacy) Input system

			if(Input.GetKeyDown(JumpKey))
				Rb.AddForce(new Vector3(0, Speed, 0));
			//transform.position += new Vector3(0, Speed * Time.deltaTime, 0);

			//if(Input.GetKey(KeyCode.A))
			//	transform.position += Vector3.left * Speed * Time.deltaTime;
			//if(Input.GetKey(KeyCode.D))
			//	transform.position += Vector3.right * Speed * Time.deltaTime;
			//if(Input.GetKey(KeyCode.W))
			//	transform.position += Vector3.forward * Speed * Time.deltaTime;
			//if(Input.GetKey(KeyCode.S))
			//	transform.position += Vector3.back * Speed * Time.deltaTime;

			//with acceleration
			Horizontal = Input.GetAxis("Horizontal");
			Vertical = Input.GetAxis("Vertical");

			//without acceleration
			Horizontal = Input.GetAxisRaw("Horizontal");
			Vertical = Input.GetAxisRaw("Vertical");

			//if(Input.GetAxis("Horizontal") < 0)
			//	transform.position += Vector3.left * Speed * Time.deltaTime;

			//transform.position += Vector3.right * Speed * Time.deltaTime * Horizontal;
			//transform.position += Vector3.forward * Speed * Time.deltaTime * Vertical;





		}

		private void FixedUpdate() {
			//pythagoras
			float directionLength = Mathf.Sqrt(Horizontal * Horizontal + Vertical * Vertical);

			if(directionLength == 0)
				return;

			//moving with physics
			//Rb.MovePosition(Rb.position + Vector3.right * Speed * Time.deltaTime * Horizontal);
			//Rb.MovePosition(Rb.position + Vector3.forward * Speed * Time.deltaTime * Vertical);

			//Rb.position += transform.right * Speed * Time.fixedDeltaTime * Horizontal / directionLength;
			//Rb.position += transform.forward * Speed * Time.fixedDeltaTime * Vertical / directionLength;

			Vector3 direction = Vector3.zero;
			direction = transform.right * Horizontal;
			direction += transform.forward * Vertical;
			direction /= directionLength;

			Rb.MovePosition(Rb.position + direction * Speed * Time.fixedDeltaTime);


		}

		//COLLISIONS

		private void OnCollisionEnter(Collision collision) {
			Debug.Log("Collision enter");
			Debug.Log($" Collided with {collision.gameObject}");

			//Enemy collidedEnemy = collision.gameObject.GetComponent<Enemy>();
			////null check
			//if(collidedEnemy != null)
			//	collidedEnemy.Health -= 10;

			//this does the same as the method above
			if(collision.gameObject.TryGetComponent(out Enemy theEnemy))
				theEnemy.Health -= 10;


		}

		private void OnCollisionExit(Collision collision) {
			Debug.Log("Collision exit");
		}

		private void OnCollisionStay(Collision collision) {
			Debug.Log("Collision stay");
		}


		//TRIGGERS

		private void OnTriggerEnter(Collider other) {
			Debug.Log($"Trigger enter: {other.gameObject}");
		}

		private void OnTriggerExit(Collider other) {
			Debug.Log("Trigger exit");
		}

		private void OnTriggerStay(Collider other) {
			Debug.Log("Trigger stay");
		}
	}
}