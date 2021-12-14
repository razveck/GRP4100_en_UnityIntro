using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityIntro {

	public class Pause{
		public static bool IsPaused;
	}

	public class Menu : MonoBehaviour {

		[SerializeField]
		private GameObject _menuGUI;


		// Use this for initialization
		void Start() {
		}

		// Update is called once per frame
		void Update() {
			if(Input.GetKeyDown(KeyCode.Escape)){
				_menuGUI.SetActive(!_menuGUI.activeSelf);
				Pause.IsPaused = !Pause.IsPaused;
				//we could do this, if we hide the mouse while playing
				//Cursor.visible = true;
			}
		}

		public void Restart(){
			SceneManager.LoadScene(gameObject.scene.buildIndex);
		}

		//IMGUI - Immediate Mode Graphical User Interface
		//private void OnGUI() {
		//	GUI.Label(new Rect(0f, 0f, 500f, 100f), "Hey what's up");
		//}

	}
}