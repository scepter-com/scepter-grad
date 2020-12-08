namespace ScepterDocuments.Core.Input
{
    public class ScepterInput
    {
        public static float GetAxis(string axis)
        {
            return UnityEngine.Input.GetAxis(axis);
        }
    }
}