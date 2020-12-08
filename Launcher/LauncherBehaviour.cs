
using System;
using UnityEditor;
using UnityEngine;

namespace ScepterDocuments.Launcher
{
    public class LauncherBehaviour : ScepterBehaviour
    {
        private Launcher _launcher;
        [SerializeField] private SceneAsset scene;
        private void Start()
        {
            this._launcher = new Launcher(scene);
        }
    }
}