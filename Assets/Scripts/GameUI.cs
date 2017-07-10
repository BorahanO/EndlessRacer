using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

    [SerializeField]
    private string textLabel;

    [SerializeField]
    private int startValue;

    private TextMesh textMesh;
    private int value;
    /*
    public int currentScore = 0;
    public int currentLives = 0;
    */
    void Awake()
    {
        textMesh = GetComponent<TextMesh>();
    }

    void Start()
    {
        UpdateUIValue(startValue);
    }
    void Update ()
    {/*
        lives = PlayerLives.currentLives;
        if (gameObject.CompareTag("lives"))
        {
            GetComponent<TextMesh>().text = "lives :" + lives;
        }
        if (gameObject.CompareTag("points"))
        {
            GetComponent<TextMesh>().text = "score :" + currentScore;
        }
        */
    }

    public void UpdateUIValue(int value)
    {
        this.value = value;
        textMesh.text = textLabel + value;
    }

    public void AddUIValue(int value)
    {
        this.value += value;
        textMesh.text = textLabel + this.value;
    }
}
