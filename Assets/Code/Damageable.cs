using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityIntro {

	public interface IDamageable{
		void DealDamage();
	}

	//public class Damageable : MonoBehaviour {
	//	public virtual void DealDamage(){
			
	//	}
	//}

	//public class DestroyOnDamage : Damageable{
	//	public override void DealDamage(){
	//		Destroy(gameObject);
	//	}
	//}

	//public class ChangeColorOnDamage : Damageable{
	//	public override void DealDamage(){
	//		GetComponent<Renderer>().material.color = Color.red;
	//	}
	//}

	//public class HealthOnDamage : Damageable{
	//	public int Health = 10;
	//	public override void DealDamage(){
	//		Health--;
	//		if(Health <= 0)
	//			Destroy(gameObject);
	//	}
	//}
}
