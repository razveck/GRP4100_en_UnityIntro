using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityIntro {
	public class LinkedList : MonoBehaviour {

		public Node First;

		public int Count() {
			int count = 0;
			Node current = First;
			//if(First is not null)
			//if(First != null)

			while(current != null) {
				count++;
				current = current.Next;
			}
			
			return count;
		}

	}
}
