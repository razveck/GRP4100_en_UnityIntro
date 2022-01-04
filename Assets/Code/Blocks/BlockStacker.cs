using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace UnityIntro.Blocks {
	public class BlockStacker : MonoBehaviour, IPointerClickHandler {

		private Stack<GameObject> _stack = new Stack<GameObject>();

		[SerializeField]
		private GameObject _blockPrefab;

		public void OnPointerClick(PointerEventData eventData) {
			//Push to add
			//Pop to remove
			//Peek to read without removing

			//if I left click, add a block
			//1. detect a left click
			if (eventData.button == PointerEventData.InputButton.Left)
			{
				Transform lastChild = FindLastChild(transform);

				Block newBlock = Instantiate(lastChild.gameObject, lastChild.position + Vector3.back, Quaternion.identity).GetComponent<Block>();

				newBlock.transform.SetParent(lastChild);
			}
			else if (eventData.button == PointerEventData.InputButton.Right)
			{ 
			
			}
				//2. instantiate a block (ideally place it on top of the previous, or in a different place)
				//3. add that new block to the stack

			//if I right click, remove a block
		}
		private Transform FindLastChild(Transform current)
		{
			if (current.childCount == 0)
			{
				return current;
			}

			Transform child = current.GetChild(0);
			return FindLastChild(child);
		}
	}
}