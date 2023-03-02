using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int gridWidth = 16;
    public int gridHeight = 8;
    public GameObject pathTile;
    private PathGenerator pathGenerator;

    // Start is called before the first frame update
    void Start()
    {
        // create a new PathGenerator with specified grid width and height
        pathGenerator = new PathGenerator(gridWidth, gridHeight);
        // generate a path using the PathGenerator and store it in a list of Vector2Int
        List<Vector2Int> pathCells = pathGenerator.GeneratePath();
        // for each Vector2Int in the pathCells list, instantiate a pathTile object at that position
        for (int i = 0; i < 500; i++)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        // empty, no update required for this script
    }
}