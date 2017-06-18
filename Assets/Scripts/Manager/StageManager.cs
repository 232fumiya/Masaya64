namespace Masaya64.Controller{	
	using UnityEngine.SceneManagement;
	using UnityEngine;
	public class StageManager : MonoBehaviour {
		void Start () {
		}

		void Update () {
		}
		void changeScreen(StagesList.stages stage){
			SceneManager.LoadScene (StagesList.getStageName(stage));
		}
	}
}