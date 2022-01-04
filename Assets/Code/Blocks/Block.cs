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
		//LIFO: last in, first out
		//FIFO: first in, first out
		//they are not data structures themselves, they are ways of accessing data in a data structure

		public void OnPointerClick(PointerEventData eventData) {
			//transform.root
			//transform.childCount
			//transform.GetChild
			//transform.parent

			Transform lastChild = FindLastChild(transform);

			Block newBlock = Instantiate(lastChild.gameObject, lastChild.position + Vector3.back, Quaternion.identity).GetComponent<Block>();

			newBlock.transform.SetParent(lastChild);
		}

		//recursive function
		//recursion
		private Transform FindLastChild(Transform current){
			if(current.childCount == 0){
				return current;
			}

			Transform child = current.GetChild(0);
			return FindLastChild(child);
		}
	}
}