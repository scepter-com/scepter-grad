using UnityEngine;

namespace ScepterDocuments.Player.Movement
{
    public interface IMovable
    {
        /// <summary>
        /// Move object with translate
        /// </summary>
        /// <param name="direction"> Direction </param>
        /// <param name="t"> Behaviour transform </param>
        /// <returns> return next position </returns>
        Vector3 Move(Vector3 direction, Transform t);
        
        /// <summary>
        /// Move object with force
        /// </summary>
        /// <param name="direction"> Direction </param>
        /// <param name="r"> Behaviour rigidbody </param>
        /// <param name="force"> movement force </param>
        /// <param name="forceMode"> force mode for rigidbody</param>
        void RigidbodyMove(Vector3 direction, 
            Rigidbody r, 
            float force,
            ForceMode forceMode);

    }
}