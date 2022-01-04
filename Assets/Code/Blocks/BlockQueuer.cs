using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace UnityIntro.Blocks {
	public class BlockQueuer : MonoBehaviour, IPointerClickHandler {

		[SerializeField]
		private Queue<GameObject> _queue = new Queue<GameObject>();

		[SerializeField]
		private GameObject _blockPrefab;

		public void OnPointerClick(PointerEventData eventData) {
			//Enqueue to add
			//Dequeue to remove
			//Peek to read without removing
			
			//if I left click, add a block
			//1. detect a left click

			//needs to be "up" because OnPointerClick is called on up
			//if(Input.GetMouseButtonUp(0))
			//	Debug.Log("Left");
			
			//prefered method: each Handler has its own eventData
			if(eventData.button == PointerEventData.InputButton.Left){
				//2. instantiate a block (ideally place it on top of the previous, or in a different place)
				GameObject obj = Instantiate(_blockPrefab, transform.position + new Vector3(0, 0, -_queue.Count), Quaternion.identity);

				//3. add that new block to the stack
				_queue.Enqueue(obj);
			}
			


			//if I right click, remove a block
			//if(Input.GetMouseButtonUp(1))
			//	Debug.Log("Right");
			if(eventData.button == PointerEventData.InputButton.Right){
				if(_queue.Count == 0)
					return;

				//1. pop (remove) a block from the stack
				GameObject objectToDelete = _queue.Dequeue();
				//2. delete it (the gameObject)
				Destroy(objectToDelete);
			}
		}
	}
}