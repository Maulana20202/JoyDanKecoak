using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartEndGame : MonoBehaviour
{

    public Spawner spawner;

    public Spawner spawner2;

    public AttackingCock Score;

    public int SpawnerCount;

    public int SpawnerTime;

    public int SpawnerSpeed;

    public GameObject BG;

    public float TimeLimit;

    public float TimeLimitCurrent;

    public TextMeshProUGUI TimeLimitTeks;

    public List<GameObject> KecoaDaftar = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TimeLimitCurrent -= Time.deltaTime;
        Menang();
        Kalah();

        TimeLimitTeks.text = TimeLimitCurrent.ToString("N0");
    }

    public void StartGame()
    {

        Time.timeScale = 1;

        spawner.speed = SpawnerSpeed;
        spawner2.speed = SpawnerSpeed;

        spawner.BatasSpawn = SpawnerCount;
        spawner2.BatasSpawn = SpawnerCount;

        spawner.DelaySpawn = SpawnerTime;
        spawner2.DelaySpawn = SpawnerTime;

        TimeLimitCurrent = TimeLimit;

        Score.Skor = 0;

        BG.SetActive(false);
    }

    public void Menang()
    {
        if(TimeLimitCurrent < 0 && Score.Skor >= 400)
        {
            Time.timeScale = 0;
            BG.SetActive(true);

            for(int i = 0; i<KecoaDaftar.Count; i++)
            {
                Destroy(KecoaDaftar[i]);
            }

            KecoaDaftar.Clear();

            Debug.Log("Menang");
        }
    }

    public void Kalah()
    {
        if (TimeLimitCurrent < 0 && Score.Skor < 400)
        {
            Time.timeScale = 0;
            BG.SetActive(true);

            for (int i = 0; i < KecoaDaftar.Count; i++)
            {
                Destroy(KecoaDaftar[i]);
            }

            KecoaDaftar.Clear();

            Debug.Log("kalah");
        }
    }
}
