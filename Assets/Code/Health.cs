using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityIntro {
	public class Health : MonoBehaviour, IDamageable {

		public void DealDamage() {
			Debug.Log("Took damage");
		}
	}
}