using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Presenter : MonoBehaviour
{
    public int scoreRatio = 4;
    public GameObject target;
    public Text scoreTxt;
    public Text bestScoreTxt;

    private int curScore = 0;
    private int curDistance = 0;

    private void Start()
    {
        bestScoreTxt.text = "best score: " + LoadBestScore();
    }

    private void Update()
    {
        DisplayScore();
    }

    private void DisplayScore()
    {
        int targetPos = Mathf.RoundToInt(target.transform.position.x);
        if (targetPos > curDistance)
        {
            curDistance++;
            if (curDistance % scoreRatio == 0)
            {
                curScore++;
            }

            scoreTxt.text = "score: " + curScore;
        }
    }

    private void SaveBestScore()
    {
        int lastScore = LoadBestScore();
        if (lastScore < curScore)
            PlayerPrefs.SetInt("score", curScore);
    }

    private int LoadBestScore()
    {
        int bestScore = PlayerPrefs.GetInt("score");
        return bestScore;
    }

    private void OnDestroy()
    {
        SaveBestScore();
    }

    public void PlayMusic_OnClick()
    {
        AudioManager.Instance.Play();
    }
    
    public void StopMusic_OnClick()
    {
        AudioManager.Instance.Stop();
    }
}
