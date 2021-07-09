using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
   

    private AsyncOperation async;

    // ...

    IEnumerator loadScene()
    {
        async = SceneManager.LoadSceneAsync("Scene", LoadSceneMode.Single);
        async.allowSceneActivation = false;
        while (async.progress < 0.9f)
        {
           // progressText.text = async.progress + "";
        }
        while (!async.isDone)
        {
            yield return null;
        }

    }

    public void showScene()
    {
        async.allowSceneActivation = true;
    }
}
