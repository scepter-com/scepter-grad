using ScepterDocuments.Core.Input;
using UnityEngine;

namespace ScepterDocuments.Player.Movement
{
    public class MovementDirection
    {
        public static Vector3 GetDirection(Transform t)
        {
            float horizontal = ScepterInput.GetAxis("Horizontal");
            float vertical = ScepterInput.GetAxis("Vertical");
            Vector3 direction = (t.forward * vertical) + (t.right * horizontal);
            return direction;
        }
    }
}