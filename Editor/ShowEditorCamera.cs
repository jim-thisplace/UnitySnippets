using UnityEditor;
using UnityEngine;
using System.Collections;

public class ShowEditorCamera : EditorWindow {

	[MenuItem ("Window/Editor Camera Position")]

	public static void  ShowWindow () {
		EditorWindow.GetWindow(typeof(ShowEditorCamera));
	}

	void OnGUI() {
		GUILayout.Label (SceneView.lastActiveSceneView.camera.transform.position.ToString(), EditorStyles.boldLabel);
	}
}