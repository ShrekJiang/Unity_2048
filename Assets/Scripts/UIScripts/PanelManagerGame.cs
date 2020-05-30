using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManagerGame : MonoBehaviour
{
    public Transform grids;
    public GameObject gridPrefab;

    private GridLayoutGroup gridLayoutGroup;
    private Dictionary<int, int> dict = new Dictionary<int, int>() {{4, 50}, {5, 39}, {6, 32}};
    private Grid[][] myGrids = null;
    private List<Grid>blankGrids=new List<Grid>();

    public void Awake()
    {
        gridLayoutGroup = grids.GetComponent<GridLayoutGroup>();
        int count = PlayerPrefs.GetInt(Const.MODE_COUNT, 4);
        gridLayoutGroup.constraintCount = count;
        gridLayoutGroup.cellSize = new Vector2(dict[count], dict[count]);
        myGrids=new Grid[count][];
        blankGrids.Clear();
        InitGrids(count);
        CreateNumber();
    }

    public void InitGrids(int count)
    {
        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < count; j++)
            {
                if(myGrids[i]==null)
                    myGrids[i]=new Grid[count];
                myGrids[i][j]=Instantiate(gridPrefab, grids).GetComponent<Grid>();
                blankGrids.Add(myGrids[i][j]);
            }
        }
    }

    public void CreateNumber()
    {
        if(blankGrids.Count==0)
            return;
        int index = Random.Range(0, blankGrids.Count);
        Grid grid = blankGrids[index];
        grid.InitNumber(grid.transform);
    }
}