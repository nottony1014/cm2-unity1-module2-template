using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shootingtimer : MonoBehaviour
{
    private float timer = 0;
    private bool isTimerRunning = false;

    public TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        SimpleSpawner[] spawners = FindObjectsOfType<SimpleSpawner>();
        for (int i = 0; i < spawners.Length; i++)
            spawners[i].enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SimpleSpawner[] spawners = FindObjectsOfType<SimpleSpawner>();
            for (int i = 0; i < spawners.Length; i++)
                spawners[i].enabled = true;

            isTimerRunning = true;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        if (isTimerRunning)
        {
            timer += Time.deltaTime;
        }

        if(timer > 60) 
        {
            isTimerRunning = false;

            SimpleSpawner[] spawners = FindObjectsOfType<SimpleSpawner>();
            for(int i =0; i < spawners.Length; i++)
                spawners[i].enabled = false;
        
        }
        timerText.text = "Time: " + timer.ToString("0.00");



    }
}
