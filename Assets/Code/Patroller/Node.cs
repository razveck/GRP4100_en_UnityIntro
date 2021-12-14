using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityIntro {
	public class Node : MonoBehaviour {
		public Node Next;

		//doubly linked list
		//public Node Previous;

		//we usually need this field, but this is a MonoBehaviour, and we already can access the gameObject there
		//public GameObject Value;
	}
}
