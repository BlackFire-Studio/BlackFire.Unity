﻿/*
--------------------------------------------------
| Copyright © 2008 Mr-Alan. All rights reserved. |
| Website: www.0x69h.com                         |
| Mail: mr.alan.china@gmail.com                  |
| QQ: 835988221                                  |
--------------------------------------------------
*/

using UnityEditor;

namespace BlackFire.Unity.Editor
{
    public static class WindowMenu 
	{
        public const string TopMenuName = "BlackFire/Basic/";

        public const string Window = "Window/";

		
		[MenuItem(TopMenuName + "ScriptableObject Creator &c")]
		private static void OnMenuItemClick_ScriptableObjectCreator()
		{
			var window = EditorWindow.GetWindow(typeof(ScriptableObjectCreatorEditorWindow), false, "Creator") as ScriptableObjectCreatorEditorWindow;
			window.position = new UnityEngine.Rect((1920f-730f)/2,(1080f-650f)/2,250f,100f);
		}
	    

		[MenuItem(TopMenuName + "Game Process &g")]
		static void OnMenuItemClick_GameProcess()
		{
			var window = EditorWindow.GetWindow(typeof(ProcessWindow), false, "Process") as ProcessWindow;
			window.position = new UnityEngine.Rect((1920f-730f)/2,(1080f-650f)/2,730f,650f);
		}
	    
		
		[MenuItem(TopMenuName + "Path/Open Data Path")]
		private static void OpenDataPath()
		{
			Utility.Project.OpenDataPath();
		}

		
		[MenuItem(TopMenuName + "Path/Open Persistent Data Path")]
		private static void OpenPersistentDataPath()
		{
			Utility.Project.OpenPersistentDataPath();
		}


		[MenuItem(TopMenuName + "Path/Open Streaming Assets Path")]
		private static void OpenStreamingAssetsPath()
		{
			Utility.Project.OpenStreamingAssetsPath();
		}

		[MenuItem(TopMenuName + "Path/Open ScriptAssemblies Path")]
		private static void OpenScriptAssembliesPath()
		{
			Utility.Project.OpenScriptAssemblies();
		}
		
		[MenuItem(TopMenuName + "Path/Open ApplicationContents Path")]
		private static void OpenApplicationContentsPath()
		{
			Utility.Project.OpenApplicationContentsPath();
		}
		
		[MenuItem(TopMenuName + "Path/Open Temporary Cache Path")]
		private static void OpenTemporaryCachePath()
		{
			Utility.Project.OpenTemporaryCachePath();
		}
		
		
		[MenuItem(TopMenuName + "/Development Scene &d")]
		private static void OpenDevelopmentScene()
		{
			var window = EditorWindow.GetWindow(typeof(DevelopmentSceneWindow), false, "DevelopmentScene") as DevelopmentSceneWindow;
			window.position = new UnityEngine.Rect((1920f-730f)/2,(1080f-650f)/2,300f,550f);
		}
		

		[MenuItem(TopMenuName + "Security/AES File")]
		private static void Security_File()
		{
			var window = EditorWindow.GetWindow(typeof(SecurityFileWindow), false, "Security File") as SecurityFileWindow;
			window.position = new UnityEngine.Rect((1920f-730f)/2,(1080f-650f)/2,400f,150f);
		}


    }
}
