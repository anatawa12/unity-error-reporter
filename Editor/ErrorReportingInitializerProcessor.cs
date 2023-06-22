using UnityEngine;
using VRC.SDK3.Avatars.Components;
using VRC.SDKBase.Editor.BuildPipeline;

namespace Anatawa12.ErrorReporter
{
    /// <summary>
    /// Initializes Error Reporting System
    /// </summary>
    internal class ErrorReporterInitializerProcessor : IVRCSDKPreprocessAvatarCallback
    {
        public int callbackOrder => int.MinValue;

        public bool OnPreprocessAvatar(GameObject avatarGameObject)
        {
            BuildReport.Clear();
            BuildReport.CurrentReport.Initialize(avatarGameObject.GetComponent<VRCAvatarDescriptor>());
            return true;
        }
    }
}
