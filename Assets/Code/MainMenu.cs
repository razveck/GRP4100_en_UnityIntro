using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityIntro {
	public class MainMenu : MonoBehaviour {
		public void StartGame(){
			SceneManager.LoadScene(1);

			//optional:
			//SceneManager.LoadScene(1, LoadSceneMode.Additive);
			//SceneManager.UnloadSceneAsync(0);
		}
	}
}
