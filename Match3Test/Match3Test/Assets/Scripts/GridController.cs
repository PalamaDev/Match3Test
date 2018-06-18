using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Match3Core;

public class GridController : Match3Core.Grid {

	public int x;
	public int y;

	public float fillTimes;
	public Level levelComponents;
	[HideInInspector]
	public bool isLoadFromFile;
	[HideInInspector]
	public string folderPath;

	public PiecePrefab[] piecePrefaes;
	public GameObject background;

	private void OnValidate()
	{
		x = (x>15)?15:x;
		y = (y>15)?15:y;
		x = (x<3)?3:x;
		y = (y<3)?3:y;

	}

	private void Start()
	{
		SetProperty (fillTimes, levelComponents, isLoadFromFile, folderPath);
		SetObject (piecePrefaes, background);
		GenerateGrid (x, y);
	}
}
