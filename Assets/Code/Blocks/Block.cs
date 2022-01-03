using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

namespace UnityIntro
{
    public class Block : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField]
        private GameObject _blockPrefab;


        public void OnPointerClick(PointerEventData eventData)
        {
            Instantiate(_blockPrefab);
        }

        
        

        // when i click the block (this gameobject) i want to add a block on top of it.
        //1. detect the click  ( when was this object clicked)
        //2. instantiate another block
        //3. put it on top of the block

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Physics.Raycast(ray);
        }

        
        
            
        


    }
}
