﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.IO
{
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.Strings", typeof(Strings).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not enough space available in the buffer..
        /// </summary>
        internal static string Arg_BufferTooSmall {
            get {
                return ResourceManager.GetString("Arg_BufferTooSmall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection..
        /// </summary>
        internal static string Argument_InvalidOffLen {
            get {
                return ResourceManager.GetString("Argument_InvalidOffLen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Offset and length were greater than the size of the SafeBuffer..
        /// </summary>
        internal static string Argument_InvalidSafeBufferOffLen {
            get {
                return ResourceManager.GetString("Argument_InvalidSafeBufferOffLen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid seek origin..
        /// </summary>
        internal static string Argument_InvalidSeekOrigin {
            get {
                return ResourceManager.GetString("Argument_InvalidSeekOrigin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are not enough bytes remaining in the accessor to read at this position..
        /// </summary>
        internal static string Argument_NotEnoughBytesToRead {
            get {
                return ResourceManager.GetString("Argument_NotEnoughBytesToRead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are not enough bytes remaining in the accessor to write at this position..
        /// </summary>
        internal static string Argument_NotEnoughBytesToWrite {
            get {
                return ResourceManager.GetString("Argument_NotEnoughBytesToWrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Offset and capacity were greater than the size of the view..
        /// </summary>
        internal static string Argument_OffsetAndCapacityOutOfBounds {
            get {
                return ResourceManager.GetString("Argument_OffsetAndCapacityOutOfBounds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The UnmanagedMemoryAccessor capacity and offset would wrap around the high end of the address space..
        /// </summary>
        internal static string Argument_UnmanagedMemAccessorWrapAround {
            get {
                return ResourceManager.GetString("Argument_UnmanagedMemAccessorWrapAround", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Buffer cannot be null..
        /// </summary>
        internal static string ArgumentNull_Buffer {
            get {
                return ResourceManager.GetString("ArgumentNull_Buffer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enum value was out of legal range..
        /// </summary>
        internal static string ArgumentOutOfRange_Enum {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_Enum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The length cannot be greater than the capacity..
        /// </summary>
        internal static string ArgumentOutOfRange_LengthGreaterThanCapacity {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_LengthGreaterThanCapacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non negative number is required..
        /// </summary>
        internal static string ArgumentOutOfRange_NeedNonNegNum {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_NeedNonNegNum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The position may not be greater or equal to the capacity of the accessor..
        /// </summary>
        internal static string ArgumentOutOfRange_PositionLessThanCapacityRequired {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_PositionLessThanCapacityRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream length must be non-negative and less than 2^31 - 1 - origin..
        /// </summary>
        internal static string ArgumentOutOfRange_StreamLength {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_StreamLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UnmanagedMemoryStream length must be non-negative and less than 2^63 - 1 - baseAddress..
        /// </summary>
        internal static string ArgumentOutOfRange_UnmanagedMemStreamLength {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_UnmanagedMemStreamLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The UnmanagedMemoryStream capacity would wrap around the high end of the address space..
        /// </summary>
        internal static string ArgumentOutOfRange_UnmanagedMemStreamWrapAround {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_UnmanagedMemStreamWrapAround", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unmanaged memory stream position was beyond the capacity of the stream..
        /// </summary>
        internal static string IndexOutOfRange_UMSPosition {
            get {
                return ResourceManager.GetString("IndexOutOfRange_UMSPosition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The method cannot be called twice on the same instance..
        /// </summary>
        internal static string InvalidOperation_CalledTwice {
            get {
                return ResourceManager.GetString("InvalidOperation_CalledTwice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to expand length of this stream beyond its capacity..
        /// </summary>
        internal static string IO_FixedCapacity {
            get {
                return ResourceManager.GetString("IO_FixedCapacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An attempt was made to move the position before the beginning of the stream..
        /// </summary>
        internal static string IO_SeekBeforeBegin {
            get {
                return ResourceManager.GetString("IO_SeekBeforeBegin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream was too long..
        /// </summary>
        internal static string IO_StreamTooLong {
            get {
                return ResourceManager.GetString("IO_StreamTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Accessor does not support reading..
        /// </summary>
        internal static string NotSupported_Reading {
            get {
                return ResourceManager.GetString("NotSupported_Reading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This operation is not supported for an UnmanagedMemoryStream created from a SafeBuffer..
        /// </summary>
        internal static string NotSupported_UmsSafeBuffer {
            get {
                return ResourceManager.GetString("NotSupported_UmsSafeBuffer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream does not support reading..
        /// </summary>
        internal static string NotSupported_UnreadableStream {
            get {
                return ResourceManager.GetString("NotSupported_UnreadableStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream does not support writing..
        /// </summary>
        internal static string NotSupported_UnwritableStream {
            get {
                return ResourceManager.GetString("NotSupported_UnwritableStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Accessor does not support writing..
        /// </summary>
        internal static string NotSupported_Writing {
            get {
                return ResourceManager.GetString("NotSupported_Writing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot access a closed Stream..
        /// </summary>
        internal static string ObjectDisposed_StreamIsClosed {
            get {
                return ResourceManager.GetString("ObjectDisposed_StreamIsClosed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot access a closed accessor..
        /// </summary>
        internal static string ObjectDisposed_ViewAccessorClosed {
            get {
                return ResourceManager.GetString("ObjectDisposed_ViewAccessorClosed", resourceCulture);
            }
        }
    }
}
