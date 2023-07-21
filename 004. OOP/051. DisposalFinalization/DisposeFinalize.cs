using Microsoft.Win32.SafeHandles; // SafeFileHandle - a wrapper for a file handle
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace D_OOP
{
    public class ResourceHolder2 : IDisposable
    {
        private readonly SafeHandle managedResource;

        public ResourceHolder2()
        {
            managedResource = new SafeFileHandle(new IntPtr(), true);
        }

        /// <summary>
        /// temporal coupling between calls
        /// </summary>
        public void Dispose()
        {
            // Dispose managed resources.
            managedResource?.Dispose();
            // GC.SuppressFinalize(this); // not necessary, we can comment this line
        }
    }

    public class ResourceHolder : IDisposable
    {
        // unmanaged resources 
        private readonly IntPtr unmanagedResource;
        // managed resources
        private readonly SafeHandle managedResource;

        public ResourceHolder()
        {
            // We are allocating unmanaged resources
            // Marshal - provides methods for allocating unmanaged memory, 
            // copying unmanaged memory blocks, and 
            // converting unmanaged data types to managed data types
            unmanagedResource = Marshal.AllocHGlobal(sizeof(int)); 
            // We are allocating managed resources
            // SafeFileHandle - a wrapper for a file handle. 
            // IntPtr.Zero - a pointer to the unmanaged memory block
            // true - indicates that the handle should be released when the SafeHandle is disposed
            managedResource = new SafeFileHandle(new IntPtr(), true); 
        }

        /// <summary>
        /// temporal coupling between calls
        /// </summary>
        public void Dispose()
        {
            // Dispose managed resources.
            Dispose(true);
            // Take yourself off the Finalization queue
            // to prevent finalization code for this object
            // from executing a second time.
            GC.SuppressFinalize(this); 
        }

        // Dispose(bool isManualDisposing) executes in two distinct scenarios.
        // If isManualDisposing equals true, the method has been called directly
        // or indirectly by a user's code. Managed and unmanaged resources can be disposed.
        // If isManualDisposing equals false, the method has been called by the runtime
        // from inside the finalizer and you should not reference other objects.
        // Only unmanaged resources can be disposed.
        protected virtual void Dispose(bool isManualDisposing)
        {
            ReleaseUnmanagedResourse(unmanagedResource);
            if (isManualDisposing)
            {
                // Dispose managed resources.
                ReleaseManagedResources(managedResource);
            }
        }

        // We can use this method to release managed resources
        // SafeHandle - a base class for classes that wrap operating system handles
        private void ReleaseManagedResources(SafeHandle safeHandle)
        {
            safeHandle?.Dispose(); 
        }

        // We can use this method to release unmanaged resources
        // IntPtr - represents a pointer to an unmanaged block of memory
        // Marshal - provides methods for allocating unmanaged memory,
        // copying unmanaged memory blocks, and converting unmanaged data types to managed data types
        private void ReleaseUnmanagedResourse(IntPtr intPtr)
        {
            Marshal.FreeHGlobal(intPtr); // frees an unmanaged memory block
        }

        // Use C# destructor syntax for finalization code.
        // This destructor will run only if the Dispose method does not get called.
        // It gives your base class the opportunity to finalize.
        ~ResourceHolder()
        {
            Dispose(false);
        }
    }
}
