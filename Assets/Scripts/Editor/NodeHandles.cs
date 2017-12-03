using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using DSAM.Utility;


[CustomEditor(typeof(Utility_Path))]
public class NodeHandles : Editor {

    Utility_Path path;

    private void OnEnable()
    {
        
    }

    void OnSceneGUI()
    {
        
        
        
        path = (Utility_Path)target;
        for (int i = 0; i < path.nodes.Count; i++)
        {
            Handles.color = Color.black;
            path.nodes[i] = Handles.PositionHandle(path.nodes[i], Quaternion.identity);
        }
        
    }
}
