using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private int oliveNumber;
    [SerializeField] private GameObject oliveObj;
    private List<GameObject> olivesList;

    private void Start()
    {
        olivesList = new List<GameObject>();
        
        
        OliveSpawner();
    }

    public void OliveSpawner()
    {
        for (int i = 0; i < oliveNumber; i++)
        {
            Instantiate(oliveObj, new Vector3(0, 3,0), Quaternion.identity);
            //olivesList.Add(newObj);
        }
        Debug.Log(olivesList.Count);
    }
}
