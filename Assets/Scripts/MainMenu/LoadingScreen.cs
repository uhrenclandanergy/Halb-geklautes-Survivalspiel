using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour {

    public Text progressText;
    public Slider LadeBalken;
    public GameObject Panel;

    public void LoadScene(int sceneIndex, string Canvasname)
    {
        GameObject clone = GameObject.Instantiate(Panel);
        clone.transform.parent = GameObject.Find(Canvasname).transform;
        StartCoroutine(LoadAsyncro(sceneIndex));
    }

    IEnumerator LoadAsyncro(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while(!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            LadeBalken.value = progress;
            progressText.text = progressText + "%";
            Debug.Log(progress);

            yield return null;
        }
    }

}
