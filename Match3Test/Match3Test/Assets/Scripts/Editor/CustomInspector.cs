using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GridController))]
public class CustomInspector : Editor {

	public override void OnInspectorGUI()
	{
		GridController myScript = target as GridController;

		base.OnInspectorGUI();

		myScript.isLoadFromFile = GUILayout.Toggle(myScript.isLoadFromFile, "IsLoadFromFile:");

		if(myScript.isLoadFromFile)
			myScript.folderPath = EditorGUILayout.TextField("Path:", myScript.folderPath);

	}
}

