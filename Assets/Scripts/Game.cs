using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public int score { get; set; } = 0;

    static Game instance = null;

    private void Awake()
    {
        instance = this;
    }

    public static Game Instance
    {
        get
        {
            return instance;
        }
    }

    public void AddPoints(int points)
    {
        score += points;
        Debug.Log(score);
    }
}
