#if UNITY_EDITOR
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

namespace Editor.Tools
{
    public class ObjectHolderWindow : OdinEditorWindow
    {
        #region Memebers

        [HorizontalGroup("This")] [SerializeField]
        private List<Object> list1;

        [HorizontalGroup("This")] [SerializeField]
        private List<Object> list2;

        [HorizontalGroup("This")] [SerializeField]
        private List<Object> list3;

        #endregion

        #region Methods

        [MenuItem("Tools/Object Holder")]
        private static void OpenWindow()
        {
            var window = GetWindow<ObjectHolderWindow>();
            window.titleContent = new GUIContent("Object Holder");
        }

        #endregion
    }
}
#endif