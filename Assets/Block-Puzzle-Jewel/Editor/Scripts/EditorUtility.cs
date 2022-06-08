using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;

public class EditorUtility : MonoBehaviour {

    [MenuItem("Bimbimnet/Plugin Setup/Check Setup", false, 1)]
    private static void SetUp()
    {
        DependencyChecker.OpenWelcomeWindow();
    }

    //[MenuItem("Block Magic Puzzle/Plugin Setup/Setup IAP Catalog",false,2)]
    //private static void SetUpIAPCatalog()
    //{
    //	string sourcePath = Application.dataPath +"/Block-Puzzle-Magic/UnityIAPCatalog/IAPProductCatalog.json";
    //	string destPath = Application.dataPath +"/Plugins/UnityPurchasing/Resources/IAPProductCatalog.json";

    //	if(File.Exists(sourcePath))
    //	{
    //		if(!File.Exists(destPath))
    //		{		
    //			File.Copy(sourcePath, destPath);
    //			AssetDatabase.Refresh();
    //		}
    //		else
    //		{
    //			Debug.LogWarning("IAP Catalog already exists.");
    //		}
    //	}
    //}

    [MenuItem("Bimbimnet/Clear PlayerPrefs")]
	private static void ClearPrefs()
	{
		PlayerPrefs.DeleteAll();
	}

	[MenuItem("Bimbimnet/Persistent Data Path/Remove All Files")]
	private static void DeleteAllFilesFromPersistentDataPath()
	{
		FileUtil.DeleteFileOrDirectory (Application.persistentDataPath);
	}

	

}
