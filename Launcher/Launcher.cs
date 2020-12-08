using UnityEditor;
using UnityEngine.SceneManagement;

namespace ScepterDocuments.Launcher
{
    public class Launcher
    {
        public Launcher(SceneAsset scene)
        {
            SceneManager.LoadScene(scene.name);
        }
    }
}