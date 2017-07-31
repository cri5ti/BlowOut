//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;
//using UnityEditor;
//using UnityEngine;
//
//[CustomEditor( typeof( Transform ) )]
//public class DrawLineEditor : Editor
//{
//	// draw lines between a chosen game object
//	// and a selection of added game objects
//
////	void OnSceneGUI()
////	{
////		Transform example = (Transform) target;
////
////		float size = HandleUtility.GetHandleSize(example.position) * 0.5f;
////		Vector3 snap = Vector3.one * 0.5f;
////
////		EditorGUI.BeginChangeCheck();
////		Vector3 newTargetPosition =
////			Handles.FreeMoveHandle(example.position, Quaternion.identity, size, snap, Handles.RectangleHandleCap);
////		if (EditorGUI.EndChangeCheck())
////		{
////			Undo.RecordObject(example, "Change Look At Target Position");
////			example.position = newTargetPosition;
////			//example.Update();
////		}
////	}
//
////		// get the chosen game object
////		DrawLine t = target as DrawLine;
////
////		if( t == null || t.GameObjects == null )
////			return;
////
////		// grab the center of the parent
////		Vector3 center = t.transform.position;
////
////		EditorGUI.BeginChangeCheck();
////		
////		// iterate over game objects added to the array...
////		for( int i = 0; i < t.GameObjects.Length; i++ )
////		{
////			if (t.GameObjects[i] == null) return;
////			
////			var pos = t.GameObjects[i].transform.position;
////			// ... and draw a line between them
////				Handles.DrawLine( center,  pos);
////
////			Handles.FreeMoveHandle(pos, Quaternion.identity, HandleUtility.GetHandleSize(pos) * 0.5f, Vector3.one,
////				Handles.RectangleHandleCap);
////		}
////		
////		
////		if (EditorGUI.EndChangeCheck())
////		{
//////			Undo.RecordObject(example, "Change Look At Target Position");
//////			example.targetPosition = newTargetPosition;
//////			example.Update();
////		}
////	}
//}