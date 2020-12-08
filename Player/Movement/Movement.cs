using ScepterDocuments.Core.Interfaces;
using UnityEngine;

namespace ScepterDocuments.Player.Movement
{
    
    public class Movement : IMovable
    {
        public Vector3 Move(Vector3 direction, Transform t)
        {
            throw new System.NotImplementedException();
        }

        public void RigidbodyMove(Vector3 direction, 
            Rigidbody r, 
            float force,
            ForceMode forceMode)
        {
            r.AddForce(direction * force, forceMode);
        }
    }
}