using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static float Score;
    public static bool isGameRunning = false;
    [Header("MainScore")]
    public TMP_Text MainScoreText;
    private float lastScore;
    private float maxScore;
    [Header("CenterButton")]
    public TMP_Text CenterButtonText;
    [Header("Canvas")]
    public Animator CanvasAnimator;
    [Header("Crown")]
    public Animator CrownAnimator;



    private void Awake()
    {
        LoadScoreData();
        UpdateMainScoreDisplaying();
    }

    public void EndGame()
    {
        
        if (!isGameRunning)
            return;
        Debug.Log("Game Ended");
        isGameRunning = false;
        CrownAnimator.SetBool("IsVisible", false);
        Time.timeScale = 1;
        CanvasAnimator.SetBool("IsInGame", false);
        SaveScoreData();
    }
    private void Update()
    {
        if (isGameRunning)
        {
            Score += Time.deltaTime * 2;
            Time.timeScale += 0.01f * Time.deltaTime;
            UpdateScoreDisplaying();
            if (Score > maxScore)
            {
                CrownAnimator.SetBool("IsVisible", true);
            }
        }
    }
    private void SaveScoreData()
    {
        lastScore = Score;
        if (Score > maxScore)
        {
            maxScore = Score;
        }
        PlayerPrefs.SetFloat("lastScore", lastScore);
        PlayerPrefs.SetFloat("maxScore", maxScore);
        PlayerPrefs.Save();
        Score = 0;
        UpdateMainScoreDisplaying();
    }
    private void LoadScoreData()
    {
        if (PlayerPrefs.HasKey("lastScore") & PlayerPrefs.HasKey("maxScore"))
        {
            lastScore = PlayerPrefs.GetFloat("lastScore");
            maxScore = PlayerPrefs.GetFloat("maxScore");
        }
        else
        {
            Debug.Log("lastScore and maxScore keys not existing");
        }
        
    }
    private void UpdateMainScoreDisplaying()
    {
        string str = Mathf.Round(maxScore).ToString();
        MainScoreText.text = str;
    }
    private void UpdateScoreDisplaying()
    {
        CenterButtonText.text = Mathf.Round(Score).ToString();
    }
    public void StartGame()
    {
        Debug.Log("Game Started");
        isGameRunning = true;
        CanvasAnimator.SetBool("IsInGame", true);
    }
}
