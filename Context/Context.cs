
using ScepterDocuments.Core;

namespace ScepterDocuments.Context
{
    public class Context
    {
        private ContextData _data;

        public ContextData Data
        {
            get => _data;
            private set => _data = value;
        }
        
    }
}

