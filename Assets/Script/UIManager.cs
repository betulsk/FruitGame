using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject StartBtn;
    [SerializeField] private Text levelTxt;

    internal void Started()
    {
        GameManager.Instance.GameState = State.Start;
        
    }
}
