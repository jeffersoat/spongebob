using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Loadingscreen : MonoBehaviour
{
    [Header("Menu Screens")]
    [SerializeField] private GameObject loadingScreen;
    [SerializeField] private GameObject mainMenu;

[Header("Menu Screens")]
[SerializeField] private Slider loadingSlider;

public void LoadingLevelBtn(string levelToLoad)
  {
    mainMenu.SetActive(false);
    loadingScreen.SetActive(true);

    //Run the A sync
  }

  IEnumerator LoadLevelASync(string levelToLoad)
{
    AsyncOperation loadOperation = SceneManager .LoadSceneAsync(levelToLoad);
    while (!loadOperation.isDone)
    {
      float progressValue = Mathf.Clamp01(loadOperation.progress / 0.9f);
      loadingSlider.value = progressValue
      yield return null;
    }
    }
}









