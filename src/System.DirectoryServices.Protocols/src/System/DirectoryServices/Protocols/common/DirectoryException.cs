// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.DirectoryServices.Protocols
{
    using System.Globalization;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    [System.Runtime.CompilerServices.TypeForwardedFrom("System.DirectoryServices.Protocols, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public class DirectoryException : Exception
    {
        protected DirectoryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public DirectoryException(string message, Exception inner) : base(message, inner)
        {
        }

        public DirectoryException(string message) : base(message)
        {
        }

        public DirectoryException() : base()
        {
        }
    }

    [Serializable]
    [System.Runtime.CompilerServices.TypeForwardedFrom("System.DirectoryServices.Protocols, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public class DirectoryOperationException : DirectoryException, ISerializable
    {
        internal DirectoryResponse response = null;
        protected DirectoryOperationException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public DirectoryOperationException() : base() { }

        public DirectoryOperationException(string message) : base(message) { }

        public DirectoryOperationException(string message, Exception inner) : base(message, inner) { }

        public DirectoryOperationException(DirectoryResponse response) : base(String.Format(CultureInfo.CurrentCulture, SR.DefaultOperationsError))
        {
            this.response = response;
        }

        public DirectoryOperationException(DirectoryResponse response, string message) : base(message)
        {
            this.response = response;
        }

        public DirectoryOperationException(DirectoryResponse response, string message, Exception inner) : base(message, inner)
        {
            this.response = response;
        }

        public DirectoryResponse Response
        {
            get
            {
                return response;
            }
        }
        
        public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            base.GetObjectData(serializationInfo, streamingContext);
        }
    }

    [Serializable]
    [System.Runtime.CompilerServices.TypeForwardedFrom("System.DirectoryServices.Protocols, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public class BerConversionException : DirectoryException
    {
        protected BerConversionException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public BerConversionException() : base(String.Format(CultureInfo.CurrentCulture, SR.BerConversionError))
        {
        }

        public BerConversionException(string message) : base(message)
        {
        }

        public BerConversionException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
