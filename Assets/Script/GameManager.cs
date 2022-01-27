using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    Start,
    Retry,
    Finish
}
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public State GameState;


    private void Awake()
    {
        Instance = this;
    }
}