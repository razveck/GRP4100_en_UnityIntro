using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityIntro {
	public class Bullet : MonoBehaviour {

		//1. store a reference to the rigidbody of the bullet
		private Rigidbody _rigidbody;

		[SerializeField]
		private float _speed = 10f;

		private int[] a;
		

		// Start is called before the first frame update
		private void Start() {
			_rigidbody = GetComponent<Rigidbody>();

			//works for a non-kinematic rigidbody
			//_rigidbody.velocity = transform.up * 10;
		}

		private void FixedUpdate() {
			_rigidbody.MovePosition(_rigidbody.position + transform.forward * _speed * Time.fixedDeltaTime);
		}

		private void OnTriggerEnter(Collider other) {
			Debug.Log("Bullet collision");


			if(other.TryGetComponent(out IDamageable damageable))
				damageable.DealDamage();


			Destroy(gameObject);
		}
	}
}
