using UnityEngine;
using ScepterDocuments.Core.Interfaces;

namespace ScepterDocuments.Player
{
    public class Player
    {
        private Rigidbody _rigidbody;
        private Animator _animator;
        private string _name;
        private int _health;

        #region properties

        public Rigidbody rigidbody
        {
            get => _rigidbody;
            set => _rigidbody = value;
        }

        public Animator animator
        {
            get => _animator;
            set => _animator = value;
        }

        public string name
        {
            get => _name;
            set => _name = value;
        }

        public int health
        {
            get => _health;
            set => _health = value;
        }

        #endregion

        public Player()
        {
            
        }

        public Player(Rigidbody rigidbody, Animator animator)
        {
            _rigidbody = rigidbody;
            _animator = animator;
        }

        public Player(Rigidbody rigidbody, Animator animator, string name, int health)
        {
            _rigidbody = rigidbody;
            _animator = animator;
            _name = name;
            _health = health;
        }
        
    }
}