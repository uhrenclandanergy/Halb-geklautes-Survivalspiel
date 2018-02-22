using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptBtn : MonoBehaviour {

    public void Play_btn()
    {
        GetComponent<LoadingScreen>().LoadScene(1,"MainMenu_Canvas");
    }

    public void Exit_btn()
    {
        Application.Quit();
    }
}
