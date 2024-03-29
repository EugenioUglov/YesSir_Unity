using System;
using System.Collections.Generic;
using UnityEngine;
using B83.Win32;

public class DragAndDropService : MonoBehaviour
{
    public Action<string[]> CallbackGetDroppedFilesPaths;
    
    void OnEnable()
    {
        // must be installed on the main thread to get the right thread id.
        UnityDragAndDropHook.InstallHook();
        UnityDragAndDropHook.OnDroppedFiles += OnFiles;
    }
    void OnDisable()
    {
        UnityDragAndDropHook.UninstallHook();
    }

    void OnFiles(List<string> aFiles, POINT aPos)
    {
        CallbackGetDroppedFilesPaths(aFiles.ToArray());


        // do something with the dropped file names. aPos will contain the 
        // mouse position within the window where the files has been dropped.
        //string str = "Dropped " + aFiles.Count + " files at: " + aPos + "\n\t" +
        //            aFiles.Aggregate((a, b) => a + "\n\t" + b);
    }
}
