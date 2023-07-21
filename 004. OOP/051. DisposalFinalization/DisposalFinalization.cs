using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.SafeHandles;
using System.Collections.Generic;

namespace OOP
{
    // managed resources - objects that are allocated on the managed heap
    // unmanaged resources - objects that are allocated on the unmanaged heap
    // IDisposable - interface that defines a single method Dispose
    // Dispose - releases all resources used by an object
    // Finalizer - method that is called by the garbage collector when an object is no longer referenced
    // Finalization - process of calling the finalizer
    // temporal coupling - the order of the calls is important
    // finalization suppression - prevents the finalizer from being called
    // finalization suppression is not guaranteed - the finalizer may still be called
    class ResourceHolder : IDisposable
    {
        private bool disposed = false;
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public ResourceHolder()
        {
            // Constructor code.
        }

        // Implement IDisposable.
        // Do not make this method virtual.
        // A derived class should not be able to override this method.
        // temporal coupling - the order of the calls is important
        public void Dispose()
        {
            Dispose(true);
            // Take yourself off the Finalization queue
            // to prevent finalization code for this object
            // from executing a second time.
            GC.SuppressFinalize(this);
        }

        // Dispose(bool disposing) executes in two distinct scenarios.
        // If disposing equals true, the method has been called directly
        // or indirectly by a user's code. Managed and unmanaged resources
        // can be disposed.
        // If disposing equals false, the method has been called by the
        // runtime from inside the finalizer and you should not reference
        // other objects. Only unmanaged resources can be disposed.
        protected virtual void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!this.disposed)
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing)
                {
                    handle.Dispose();
                    // Dispose managed resources.
                }

                // Call the appropriate methods to clean up
                // unmanaged resources here.
                // If disposing is false,
                // only the following code is executed.

                // Note disposing has been done.
                disposed = true;

            }
        }

        ~ResourceHolder()
        {
            // Do not re-create Dispose clean-up code here.
            // Calling Dispose(false) is optimal in terms of
            // readability and maintainability.
            Dispose(false);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (ResourceHolder rh = new ResourceHolder())
            {
                // Use the resource holder.
            }
            // The resource holder is disposed here.
        }
    }
}