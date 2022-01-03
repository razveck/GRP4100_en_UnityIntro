using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityIntro.Assets.Code.Blocks
{
    public class Block : MonoBehaviour , IPointerClickHandler
    {
        private GameObject _blockPrefab;
        private GameObject newThing;
        private Transform newChild;
        [SerializeField]
        private bool isTouching = false;


        public void OnPointerClick(PointerEventData eventData)
        {

            newThing = Instantiate(gameObject,transform.position + (Vector3.back /* transform.childCount*/), Quaternion.identity);
            //   SetParent(transform);
            newThing.transform.SetParent(transform);

        }


        /////RECURSIVELY CHECK CHILD 0 - 1 ; if 0; create child, if 1 



        //////////public void SetParent(Transform newParent)
        //////////{
        //////////    //Makes the GameObject "newParent" the parent of the GameObject "player".
        //////////    gameObject.transform.parent = newParent.transform;

        //////////    ////////Display the parent's name in the console.
        //////////    //////Debug.Log("Player's Parent: " + gameObject.transform.parent.name);

        //////////    //////// Check if the new parent has a parent GameObject.
        //////////    //////if (newParent.transform.parent != null)
        //////////    //////{
        //////////    //////    //Display the name of the grand parent of the player.
        //////////    //////    Debug.Log("Player's Grand parent: " + gameObject.transform.parent.parent.name);
        //////////    //////}
        //////////}

        //when I click the block (this game object), I want to add a block on top of it.
        // 1- detect a click with raycast
        // 2- instantiate another block (a copy of clicked)
        // 3- put it on top of the block
        // 4 - ALWAYS instantiate a block at the top of the pile
        // 5- LIFO FIFO ?

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Block"))
            { 
                isTouching = true;
            }
        }
        // Update is called once per frame
        void Update()
        {
            if (isTouching)
            {
                gameObject.transform.SetParent(this.transform);
            }
            else
            {
                gameObject.transform.SetParent(null);

            }
        }

        private void OnMouseDown()
        {
            // dont use this, because, when this is used, it goes through all elements.
        }


    }
}