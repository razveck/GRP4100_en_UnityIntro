using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

namespace UnityIntro.Blocks {
	public class Block : MonoBehaviour, IPointerClickHandler {
		

		//when I click the block (this GameObject), I want to add a block on top of it
		//1. detect a click (when was this object clicked)
		//2. instantiate another block (a copy of this)
		//3. put it on top of the block
		//4. always instantiate a block at the top of the pile

		//extra: LIFO, FIFO?

		public void OnPointerClick(PointerEventData eventData) {
			Instantiate(gameObject, transform.position + Vector3.back, Quaternion.identity);
		}

		// Update is called once per frame
		void Update() {
			//Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			//Physics.Raycast(ray);
		}

		//private void OnMouseDown() {
		//	//don't use this
		//}
	}
}