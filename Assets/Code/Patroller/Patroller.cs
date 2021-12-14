using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityIntro {
	public class Patroller : MonoBehaviour {

		private Node _target;

		private Transform _closest = null;

		private Transform _farthest = null;

		public LinkedList List;

		[SerializeField]
		private Transform[] _pointsOfInterest;

		[SerializeField]
		private float _speed = 1f;

		[SerializeField]
		private float _minimumWaypointDistance = 0.01f;

		[SerializeField]
		private Material _white;

		[SerializeField]
		private Material _red;

		[SerializeField]
		private Material _green;

		// Start is called before the first frame update
		void Start() {
			Debug.Log(List.Count());
			_target = List.First;
		}

		// Update is called once per frame
		void Update() {
			//check if we are at the target
			if(_target != null && Vector3.Distance(transform.position, _target.transform.position) < _minimumWaypointDistance && _target.Next != null)
				_target = _target.Next;

			//move
			Vector3 direction = _target.transform.position - transform.position;
			//direction = direction / direction.normalized.magnitude;
			direction.Normalize();

			transform.Translate(direction * Time.deltaTime * _speed);

			Min();
			Max();

			//LinkedList<int> linked = new LinkedList<int>();
			//System.Math.Min();
			//Mathf.Min();

			//Sort();
			BubbleSort();
		}

		//find the point of interest closest to the patroller
		//find the PoI with the MINIMUM distance
		public float Min() {
			float minDistance = float.PositiveInfinity;

			for(int i = 0; i < _pointsOfInterest.Length; i++) {
				float distance = Vector3.Distance(_pointsOfInterest[i].position, transform.position);


				if(distance < minDistance) {
					minDistance = distance;

					if(_closest != null) {
						_closest.GetComponent<Renderer>().material = _white;
					}

					_closest = _pointsOfInterest[i];
					_pointsOfInterest[i].GetComponent<Renderer>().material = _red;
				}

			}


			//output the minimum distance
			return minDistance;
		}

		public float Max() {
			float maxDistance = float.NegativeInfinity;

			for(int i = 0; i < _pointsOfInterest.Length; i++) {
				if(_pointsOfInterest[i] == _closest)
					continue;

				float distance = Vector3.Distance(_pointsOfInterest[i].position, transform.position);


				if(distance > maxDistance) {
					maxDistance = distance;

					if(_farthest != null) {
						_farthest.GetComponent<Renderer>().material = _white;
					}

					_farthest = _pointsOfInterest[i];
					_pointsOfInterest[i].GetComponent<Renderer>().material = _green;
				}

			}


			//output the minimum distance
			return maxDistance;
		}

		//sort the array from closest to farthest
		//4, 10, 8, 2, 3, 12, 9 -> 2, 3, 4, 8, 9, 10, 12

		//n = 0 distance1 = 2
		//i = 3 distance2 = 4
		//2, 10, 8, 4, 3, 12, 9

		//n = 0 distance1 = 2
		//i = 4 distance2 = 3
		//2, 10, 8, 4, 3, 12, 9

		//n = 1 distance1 = 10
		//i = 2 distance2 = 8
		//2, 8, 10, 4, 3, 12, 9

		//n = 1 distance1 = 4
		//i = 3 distance2 = 8
		//2, 4, 10, 8, 3, 12, 9

		//n = 1 distance1 = 3
		//i = 4 distance2 = 4
		//2, 3, 10, 8, 4, 12, 9

		//n = 2 distance1 = 8
		//i = 3 distance2 = 10
		//2, 3, 8, 10, 4, 12, 9

		//n = 2 distance1 = 8
		//i = 4 distance2 = 4
		//2, 3, 4, 10, 8, 12, 9

		//n = 5 distance1 = 12
		//i = 5 distance2 = 10
		//2, 3, 4, 8, 9, 10, 12

		private void Sort() {
			for(int n = 0; n < _pointsOfInterest.Length; n++) {
				Transform poi1 = _pointsOfInterest[n];
				float distance1 = Vector3.Distance(poi1.position, transform.position);

				//nested loop
				for(int i = n; i < _pointsOfInterest.Length; i++) {
					Transform poi2 = _pointsOfInterest[i];
					float distance2 = Vector3.Distance(poi2.position, transform.position);

					if(distance1 > distance2) {
						Transform temp = poi1;
						poi1 = poi2;
						poi2 = temp;
						_pointsOfInterest[n] = poi2;
						_pointsOfInterest[i] = poi1;


						float tempDistance = distance1;
						distance1 = distance2;
						distance2 = tempDistance;
					}
				}
			}
		}

		//n = 0
		//i = 0
		//4, 10, 8, 2, 3, 12, 9

		//n = 0
		//i = 1
		//4, 8, 10, 2, 3, 12, 9

		//n = 0
		//i = 2
		//4, 8, 2, 10, 3, 12, 9
		
		//n = 0
		//i = 3
		//4, 8, 2, 3, 10, 12, 9

		//n = 0
		//i = 4
		//4, 8, 2, 3, 10, 12, 9

		//n = 0
		//i = 5
		//4, 8, 2, 3, 10, 9, 12

		
		//2, 3, 4, 8, 9, 10, 12

		private void BubbleSort() {
			for(int n = 0; n < _pointsOfInterest.Length; n++) {
				//nested loop
				for(int i = 0; i < _pointsOfInterest.Length - 1; i++) {
					float distance1 = Vector3.Distance(_pointsOfInterest[i].position, transform.position);
					float distance2 = Vector3.Distance(_pointsOfInterest[i + 1].position, transform.position);

					if(distance1 > distance2) {
						Transform temp = _pointsOfInterest[i];
						_pointsOfInterest[i] = _pointsOfInterest[i + 1];
						_pointsOfInterest[i + 1] = temp;
					}
				}
			}
		}
	}
}
