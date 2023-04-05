using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public sealed class MatchBoard : MonoBehaviour
{
    public static MatchBoard Instance { get; private set; }

    public MatchRow[] rows;

    public Tile[,] Tiles { get; private set; }

    public int Width => Tiles.GetLength(0);
    public int Height => Tiles.GetLength(1);

    private void Awake() => Instance = this;

    private void Start()
    {
        Tiles = new Tile[rows.Max(row => row.tiles.Length), rows.Length];


    }
}
