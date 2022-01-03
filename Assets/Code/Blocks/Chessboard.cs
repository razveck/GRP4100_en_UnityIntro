using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityIntro
{

	public class Chessboard : MonoBehaviour
	{

		/*
		2D array
		0,0		1,0		2,0
		0,1		1,1		2,1
		0,2		1,2		2,2
		0,3		1,3		2,3
		int[] simpleArray = new int[10];
		int[,] twoDArray = new int[3, 4];
		*/


		/*
		Jagged array (array of arrays)
		0,0		1,0		2,0
		0,1		1,1
		0,2		1,2		2,2
		0,3		1,3		2,3		3,3
		jaggedArray: pointer0 pointer1 pointer2 pointer3
		jaggedArray[0]: 54, 98, 3, 56, 46, 82
		jaggedArray[1]: 5, 3, 4, 35
		jaggedArray[2]: 0, 10, 100, 3, 34, 546, 5745, 2677
		int[][] jaggedArray = new int[10][];
		*/



		//1. make a chessboard data structure
		//2. know which squares are black or white

		//form team
		//create branch
		//implement
		//commit and push

		private bool[,] _board;

		[SerializeField]
		private GameObject _blockPrefab;


		// Start is called before the first frame update
		void Start()
		{
			//Debug.Log(twoDArray[0, 0]);
			//Debug.Log(jaggedArray[0][0]);

			//jaggedArray[2] = new int[20];

			//jaggedArray[2] = new int[10];
			CreateBoard();
		}

		private void CreateBoard()
		{
			int boardSize = 8;
			_board = new bool[boardSize, boardSize];

			for (int x = 0; x < boardSize; x++)
			{
				for (int y = 0; y < boardSize; y++)
				{
					//modulo %
					//10 % 3 = 1
					//10 % 2 == 0 EVEN NUMBER
					//11 % 2 == 1 ODD NUMBER

					//0  0 1 2 3 4 5 6 7
					//1  0 1 2 3 4 5 6 7
					//2  0 1 2 3 4 5 6 7
					//3  0 1 2 3 4 5 6 7
					//4  0 1 2 3 4 5 6 7
					//5  0 1 2 3 4 5 6 7
					//6  0 1 2 3 4 5 6 7
					//7  0 1 2 3 4 5 6 7

					bool yEven = y % 2 == 0;
					bool xOdd = x % 2 == 1;
					_board[x, y] = yEven ^ xOdd;
					_board[x, y] = (x + y) % 2 == 0;
					GameObject block = Instantiate(_blockPrefab, new Vector3(x, y), Quaternion.identity);
					block.GetComponent<Renderer>().material.color = _board[x, y] ? Color.white : Color.black;
				}
			}
		}
		
	}
}