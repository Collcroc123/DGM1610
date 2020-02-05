using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    //Brackeys' Transition tutorial
    public Button play;
    private int currentScene = SceneManager.GetActiveScene().buildIndex;
    public Animator transitionFade;
    public float transTime = 1;

    // Update is called once per frame
    void Update()
    {
        play.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        transitionFade.SetTrigger("Start");
        yield return new WaitForSeconds(transTime);
        SceneManager.LoadScene(currentScene++);
    }
}
