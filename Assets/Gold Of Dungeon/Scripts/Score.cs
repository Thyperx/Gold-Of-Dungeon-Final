using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public static Score Instance;

    public int score = 0;
    public TextMeshProUGUI scoreText;
    [SerializeField] private GameObject doorShowfirst;
    [SerializeField] private GameObject doorShowsecond;
    [SerializeField] private GameObject doorShowthird;

    private void Awake()
    {
        // Singleton örnek oluþturulduðunda kendisini ayarla
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();

        if (score >= 100 && doorShowfirst != null && !doorShowfirst.activeSelf)
        {
            doorShowfirst.SetActive(true);
        }

        if (score >= 500 && doorShowsecond != null && !doorShowsecond.activeSelf)
        {
            doorShowsecond.SetActive(true);
        }

        if (score >= 1500 && doorShowthird != null && !doorShowthird.activeSelf)
        {
            doorShowthird.SetActive(true);
        }
    }

    void UpdateScoreText()
    {
        // Eðer scoreText null deðilse, ekrana puaný bastýr
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
