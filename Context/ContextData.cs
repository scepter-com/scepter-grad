using System;
using ScepterDocuments.Core;

namespace ScepterDocuments.Context
{
    
    public struct ContextData
    {
        
        private int _contextId;
        private string _session;

        public int ContextId
        {
            get => _contextId;
            set => _contextId = value;
        }

        public string Session
        {
            get => _session;
            set => _session = value;
        }
    }
}