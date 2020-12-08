
using ScepterDocuments.Core.Interfaces;
using UnityEngine;

namespace ScepterDocuments.Player
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(Collider))]
    public class PlayerRootBehaviour : ScepterBehaviour, IUpdatable, IInitializable
    {
        private Player _model;
        private void Start()
        {
            ((IInitializable) this).Initialize();
        }

        public void Tick()
        {
            
        }

        void IInitializable.Initialize()
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            Animator a = GetComponent<Animator>();
            
            if (this._model == null)
            {
                _model = new Player(rb, a);
            }
        }
    }
}