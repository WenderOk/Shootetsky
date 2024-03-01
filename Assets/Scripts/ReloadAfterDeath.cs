using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ReloadAfterDeath : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.R)) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
