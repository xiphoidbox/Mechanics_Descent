using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathGenerator
{
    private int width, height;
    private List<Vector2Int> pathCells;

    // Constructor that takes the width and height of the grid as parameters
    public PathGenerator(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    // Method that generates a list of Vector2Int representing the path cells
    public List<Vector2Int> GeneratePath()
    {
        // Initialize the list of path cells
        pathCells = new List<Vector2Int>();
        // Determine the vertical position of the path cells
        int y = (int)(height / 2);
        // Iterate through the width of the grid, adding a path cell for each x value
        for (int x = 0; x < width; x++)
        {
            pathCells.Add(new Vector2Int(x, y));
        }
        // Return the list of path cells
        return pathCells;
    }
}