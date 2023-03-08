using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int gridWidth = 16;
    public int gridHeight = 8;
    public int minPathLength = 30;
    public GameObject pathTile;
    private PathGenerator pathGenerator;

    // Start is called before the first frame update
    void Start()
    {
        pathGenerator = new PathGenerator(gridWidth, gridHeight);
        List<Vector2Int> pathCells = pathGenerator.GeneratePath();
        int pathSize = pathCells.Count;
        while (pathSize < minPathLength) 
        {
            pathCells = pathGenerator.GeneratePath();
            pathSize = pathCells.Count;
        }
        foreach (Vector2Int pathCell in pathCells)
        {
            Instantiate(pathTile, new Vector2(pathCell.x, pathCell.y), Quaternion.identity);;
        }
    }

    void Update()
    {

    }
}