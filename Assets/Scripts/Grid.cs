using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Grid : MonoBehaviour
{
    private Number number;
    public GameObject numberPrefab;

    public void Awake()
    {
        number = GetComponent<Number>();
    }

    public Boolean IsHaveNumber()
    {
        return number != null;
    }

    public void InitNumber(Transform grid)
    {
        
        Number n=GameObject.Instantiate(numberPrefab, grid).GetComponent<Number>();
        int r = Random.Range(1, 3);
        n.SetText((r*2).ToString());
    }
}
