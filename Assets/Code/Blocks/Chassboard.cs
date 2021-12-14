using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityIntro
{
    public class Chessboard : MonoBehaviour
    {
        //Regular array
        //int [] simpleArray = new int[10];
        // 2D Array
        //int [,] twoDArray = new int[10, 10];
        //Jagged array (array of arrays)
        //int [] [] jaggedArray = new int[10] [];
        /*
         works like
        0,0   1,0   2,0
        0,1   1,1   2,1
        jaggedArray [0]: 2, 5, 32
        jaggedArray [1]: 34, 54, 66
        jaggedArray [2]: 0, 1, 2
        2,1 = 1 since it's asking for the SECOND number of Array 2
        */
        // Start is called before the first frame update
        //Make a chessboard Data Structure 
        //know which squares are black or white
        //form team branch
        //create code
        //commit and push

        //Variables
        int black = 0;
        int white = 1;
        void Start()
        {
            int[,] chessBoard = new int[7, 7];
            chessBoard[0, 0] = black;
            chessBoard[0, 1] = white;
            chessBoard[0, 2] = black;
            chessBoard[0, 3] = white;
            chessBoard[0, 4] = black;
            chessBoard[0, 5] = white;
            chessBoard[0, 6] = black;
            chessBoard[0, 7] = white;
            chessBoard[1, 0] = white;
            chessBoard[1, 1] = black;
            chessBoard[1, 2] = white;
            chessBoard[1, 3] = black;
            chessBoard[1, 4] = white;
            chessBoard[1, 5] = black;
            chessBoard[1, 6] = white;
            chessBoard[1, 7] = black;
            chessBoard[2, 0] = black;
            chessBoard[2, 1] = white;
            chessBoard[2, 2] = black;
            chessBoard[2, 3] = white;
            chessBoard[2, 4] = black;
            chessBoard[2, 5] = white;
            chessBoard[2, 6] = black;
            chessBoard[2, 7] = white;
            chessBoard[3, 0] = white;
            chessBoard[3, 1] = black;
            chessBoard[3, 2] = white;
            chessBoard[3, 3] = black;
            chessBoard[3, 4] = white;
            chessBoard[3, 5] = black;
            chessBoard[3, 6] = white;
            chessBoard[3, 7] = black;
            chessBoard[4, 0] = black;
            chessBoard[4, 1] = white;
            chessBoard[4, 2] = black;
            chessBoard[4, 3] = white;
            chessBoard[4, 4] = black;
            chessBoard[4, 5] = white;
            chessBoard[4, 6] = black;
            chessBoard[4, 7] = white;
            chessBoard[5, 0] = white;
            chessBoard[5, 1] = black;
            chessBoard[5, 2] = white;
            chessBoard[5, 3] = black;
            chessBoard[5, 4] = white;
            chessBoard[5, 5] = black;
            chessBoard[5, 6] = white;
            chessBoard[5, 7] = black;
            chessBoard[6, 0] = black;
            chessBoard[6, 1] = white;
            chessBoard[6, 2] = black;
            chessBoard[6, 3] = white;
            chessBoard[6, 4] = black;
            chessBoard[6, 5] = white;
            chessBoard[6, 6] = black;
            chessBoard[6, 7] = white;
            chessBoard[7, 0] = white;
            chessBoard[7, 1] = black;
            chessBoard[7, 2] = white;
            chessBoard[7, 3] = black;
            chessBoard[7, 4] = white;
            chessBoard[7, 5] = black;
            chessBoard[7, 6] = white;
            chessBoard[7, 7] = black;
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}
