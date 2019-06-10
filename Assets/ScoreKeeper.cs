using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public static ScoreKeeper instance;
    private Text txt;

    private int score;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Score: " + score.ToString();
    }

    /// <summary>
    /// Adds the given score to the total score.
    /// </summary>
    /// <param name="score"></param>
    public void AddScore(int score)
    {
        this.score += score;
    }
}
