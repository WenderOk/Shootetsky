using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject CreditsWindow;
    private void Start()
    {
        CreditsWindow.SetActive(false);
    }
    public void StartGame() { SceneManager.LoadScene(1); }
    public void CloseGame() { Application.Quit(); }
}
