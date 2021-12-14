using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityIntro {
	public class Shoot : MonoBehaviour {

		[SerializeField]
		private GameObject _bulletPrefab;

		[SerializeField]
		private bool _useBullets;

		// Start is called before the first frame update
		void Start() {
			//GameObject bullet = new GameObject("Bullet", new System.Type[]{ typeof(BoxCollider), typeof(Rigidbody) });
			//bullet.AddComponent<MeshRenderer>();

		}

		// Update is called once per frame
		void Update() {
			if(Input.GetKeyDown(KeyCode.Mouse0)) {
				if(_useBullets) {
					Instantiate(_bulletPrefab, transform.position, transform.rotation);
				} else {
					if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hit)) {
						Debug.Log(hit.collider.gameObject.name);

						if(hit.collider.TryGetComponent(out IDamageable damageable))
							damageable.DealDamage();

					} else {
						Debug.Log("Didn't hit any collider");
					}
				}

			}
		}
	}
}
