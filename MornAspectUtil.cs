using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace MornAspect
{
    internal static class MornAspectUtil
    {
#if DISABLE_MORN_ASPECT_LOG
        private const bool ShowLOG = false;
#else
        private const bool ShowLOG = true;
#endif
        private const string Prefix = "[<color=green>MornAspect</color>] ";

        internal static void Log(string message)
        {
            if (ShowLOG) Debug.Log(Prefix + message);
        }

        internal static void LogError(string message)
        {
            if (ShowLOG) Debug.LogError(Prefix + message);
        }

        internal static void LogWarning(string message)
        {
            if (ShowLOG) Debug.LogWarning(Prefix + message);
        }

        internal static void SetDirty(Object obj)
        {
#if UNITY_EDITOR
            EditorUtility.SetDirty(obj);
#endif
        }
    }
}