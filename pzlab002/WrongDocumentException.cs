using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarypzlab002
{

	[Serializable]
	public class WrongDocumentException : ApplicationException
    {
		public WrongDocumentException() { }
		public WrongDocumentException(string message) : base(message) { }
		public WrongDocumentException(string message, Exception inner) : base(message, inner) { }
		protected WrongDocumentException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
