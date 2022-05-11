using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    float totalSeconds = 0f;
    float elapsedSeconds = 0f;
    bool running = false;
    bool started = false;
    float startTime;

    public float Duration
    {
        set
        {
            if (!running)
            {
                totalSeconds = value;
            }
        }
    }
    public bool Finished
    {
        get { return started && !running; }
    }
    public bool Running
    {
        get { return running; }
    }

    void Start()
    {
        Duration = 3;
        Run();
        totalSeconds = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        if (Finished)
        {
            float elapsedTime = Time.time - startTime;
            print("Timer ran for " + elapsedTime + " seconds");
            // save start time and restart timer
            totalSeconds = Time.time;
            Run();
        }

    }
    public void Run()
    {
        // only run with valid duration
        if (totalSeconds > 0)
        {
            started = true;
            running = false;
        }
    }

}
