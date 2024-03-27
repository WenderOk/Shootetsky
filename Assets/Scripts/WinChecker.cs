using System.Collections.Generic;
using UnityEngine;

public class WinChecker : MonoBehaviour
{
    private bool IsWon=false;

    public GameObject WinScreen;

    public float DeadEnemies;
    public List<EnemyAI> NumberOfEnemies;
    public GameObject Group2;
    public GameObject Group3;

    public AudioClip TheSong;
    public AudioSource MainMusic;
    private void Start()
    {
        WinScreen.SetActive(false);
    }
    void Update()
    {
        if(IsWon==false)
        {
            Winning();
        }
    }

    private void Winning()
    {
        if (DeadEnemies >= NumberOfEnemies.Count)
        {
            IsWon = true;

            MainMusic.enabled = false;
            WinScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            FindObjectOfType<PIGrotation>().enabled = true;
            GetComponent<AudioSource>().enabled = true;
        }
        else if (DeadEnemies == NumberOfEnemies.Count / 3) Group2.SetActive(true);
        else if (DeadEnemies == NumberOfEnemies.Count / 1.5f) Group3.SetActive(true);
    }
}
