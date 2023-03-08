using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathGenerator
{
    private int width, height;
    private List<Vector2Int> pathCells;

    public PathGenerator(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public List<Vector2Int> GeneratePath()
    {
        pathCells = new List<Vector2Int>();
        int y = (int)(height / 2);
        int x = 0;
        while (x < width)
        {
            pathCells.Add(new Vector2Int(x, y));
            bool validMove = false;
            while(!validMove)
            {
                int move = Random.Range(0, 3);
                if (move == 0 || x % 2 == 0 || x > (width - 2))
                {
                    x++;
                    validMove = true;
                }
                else if (move == 1 && CellIsFree(x, y + 1) && y < (height - 2))
                {
                    y++;
                    validMove = true;
                }
                else if (move == 2 && CellIsFree(x, y - 1) && y > 2)
                {
                    y--;
                    validMove = true;
                }
            }
        }
        return pathCells;
    }

    private bool CellIsFree(int x, int y)
    {
        return !pathCells.Contains(new Vector2Int(x, y));
    }

    private bool CellIsntFree(int x, int y)
    {
        return pathCells.Contains(new Vector2Int(x, y));
    }

    private int getCellNeighbourValue(int x, int y)
    {
        int returnValue = 0;
        if (CellIsntFree(x, y - 1))
        {
            returnValue += 1;
        }

        if (CellIsntFree(x, y + 1))
        {
            returnValue += 8;
        }

        if (CellIsntFree(x - 1, y))
        {
            returnValue += 2;
        }

        if (CellIsntFree(x + 1, y))
        {
            returnValue += 4;
        }
        return returnValue;
    }
}