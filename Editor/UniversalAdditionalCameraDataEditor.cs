using UnityEngine.Rendering.Universal;

namespace UnityEditor.Rendering.Universal
{
    [CanEditMultipleObjects]
    // Disable the GUI for additional camera data
    [CustomEditor(typeof(UniversalAdditionalCameraData))]
    class UniversalAdditionalCameraDataEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            var asset = (UniversalAdditionalCameraData)target;
            asset.requiresTransparentOption = (CameraOverrideOption)EditorGUILayout.EnumPopup("Transparent Copy", asset.requiresTransparentOption);
        }

        [MenuItem("CONTEXT/UniversalAdditionalCameraData/Remove Component")]
        static void RemoveComponent(MenuCommand command)
        {
            EditorUtility.DisplayDialog("Component Info", "You can not delete this component, you will have to remove the camera.", "OK");
        }
    }
}
