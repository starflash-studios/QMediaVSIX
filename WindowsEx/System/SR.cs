// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable enable
using System.Resources;
using System.Runtime.CompilerServices;

namespace FxResources.System.Runtime.WindowsRuntime {
    internal static class SR { }
}

namespace System {
    internal static partial class SR {
        private static global::System.Resources.ResourceManager s_resourceManager;
        internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(FxResources.System.Runtime.WindowsRuntime.SR)));

        /// <summary>The specified buffer index is not within the buffer capacity.</summary>
        internal static string @Argument_BufferIndexExceedsCapacity => GetResourceString("Argument_BufferIndexExceedsCapacity");
        /// <summary>The specified useful data length exceeds the capacity of this buffer.</summary>
        internal static string @Argument_BufferLengthExceedsCapacity => GetResourceString("Argument_BufferLengthExceedsCapacity");
        /// <summary>The specified index is out of bounds of the specified array.</summary>
        internal static string @Argument_IndexOutOfArrayBounds => GetResourceString("Argument_IndexOutOfArrayBounds");
        /// <summary>The specified Windows Runtime stream supports the IRandomAccessStream interface and its CanRead property returns TRUE, however it does not implement the IInputStream interface. Windows Runtime streams with such inconsistent capabilities cannot be converted ...</summary>
        internal static string @Argument_InstancesImplementingIRASThatCanReadMustImplementIIS => GetResourceString("Argument_InstancesImplementingIRASThatCanReadMustImplementIIS");
        /// <summary>The specified Windows Runtime stream supports the IRandomAccessStream interface and its CanWrite property returns TRUE, however it does not implement the IOutputStream interface. Windows Runtime streams with such inconsistent capabilities cannot be convert ...</summary>
        internal static string @Argument_InstancesImplementingIRASThatCanWriteMustImplementIOS => GetResourceString("Argument_InstancesImplementingIRASThatCanWriteMustImplementIOS");
        /// <summary>The specified array does not contain the specified number of elements starting at the specified offset.</summary>
        internal static string @Argument_InsufficientArrayElementsAfterOffset => GetResourceString("Argument_InsufficientArrayElementsAfterOffset");
        /// <summary>The specified buffer capacity is not sufficient to hold data of the specified length.</summary>
        internal static string @Argument_InsufficientBufferCapacity => GetResourceString("Argument_InsufficientBufferCapacity");
        /// <summary>The specified source buffer does not contain the specified number of elements starting at the specified offset.</summary>
        internal static string @Argument_InsufficientSpaceInSourceBuffer => GetResourceString("Argument_InsufficientSpaceInSourceBuffer");
        /// <summary>The specified destination buffer is not large enough to hold the specified number of bytes starting at the specified offset.</summary>
        internal static string @Argument_InsufficientSpaceInTargetBuffer => GetResourceString("Argument_InsufficientSpaceInTargetBuffer");
        /// <summary>Cannot convert the specified Stream object to a Windows Runtime stream because it does not have sufficient capabilities. In order to convert a System.IO.Stream instance to a Windows Runtime stream at least one of the properties CanRead, CanWrite, CanSeek m ...</summary>
        internal static string @Argument_NotSufficientCapabilitiesToConvertToWinRtStream => GetResourceString("Argument_NotSufficientCapabilitiesToConvertToWinRtStream");
        /// <summary>The specified object cannot be converted to a System.IO.Stream instance because it is not a Windows Runtime stream. In order to convert an object to a Stream instance it must implement at least one of the following 3 Windows Runtime stream interfaces: IInp ...</summary>
        internal static string @Argument_ObjectMustBeWinRtStreamToConvertToNetFxStream => GetResourceString("Argument_ObjectMustBeWinRtStreamToConvertToNetFxStream");
        /// <summary>The specified relative path may not consist of whitespace only</summary>
        internal static string @Argument_RelativePathMayNotBeWhitespaceOnly => GetResourceString("Argument_RelativePathMayNotBeWhitespaceOnly");
        /// <summary>The specified stream position is beyond the end of the stream.</summary>
        internal static string @Argument_StreamPositionBeyondEOS => GetResourceString("Argument_StreamPositionBeyondEOS");
        /// <summary>The specified AsyncResult does not correspond to any outstanding IO operation.</summary>
        internal static string @Argument_UnexpectedAsyncResult => GetResourceString("Argument_UnexpectedAsyncResult");
        /// <summary>The specified Windows Runtime stream does not support reading nor writing. Windows Runtime streams with such capabilities cannot be converted to managed Stream objects. Use a Windows Runtime stream that can support reading, writing or both.</summary>
        internal static string @Argument_WinRtStreamCannotReadOrWrite => GetResourceString("Argument_WinRtStreamCannotReadOrWrite");
        /// <summary>Cannot set the length of a stream to a negative value.</summary>
        internal static string @ArgumentOutOfRange_CannotResizeStreamToNegative => GetResourceString("ArgumentOutOfRange_CannotResizeStreamToNegative");
        /// <summary>Cannot seek to an absolute stream position that is negative.</summary>
        internal static string @ArgumentOutOfRange_IO_CannotSeekToNegativePosition => GetResourceString("ArgumentOutOfRange_IO_CannotSeekToNegativePosition");
        /// <summary>The specified value is not a valid member of the InputStreamOptions enumeration.</summary>
        internal static string @ArgumentOutOfRange_InvalidInputStreamOptionsEnumValue => GetResourceString("ArgumentOutOfRange_InvalidInputStreamOptionsEnumValue");
        /// <summary>Non-negative number required.</summary>
        internal static string @ArgumentOutOfRange_NeedNonNegNum => GetResourceString("ArgumentOutOfRange_NeedNonNegNum");
        /// <summary>The buffer size for a Windows Runtime stream adapter may not be negative. Use a positive buffer size or 0 to disable buffering.</summary>
        internal static string @ArgumentOutOfRange_WinRtAdapterBufferSizeMayNotBeNegative => GetResourceString("ArgumentOutOfRange_WinRtAdapterBufferSizeMayNotBeNegative");
        /// <summary>The state of this object does not permit invoking this method.</summary>
        internal static string @InvalidOperation_CannotCallThisMethodInCurrentState => GetResourceString("InvalidOperation_CannotCallThisMethodInCurrentState");
        /// <summary>Cannot convert the specified Windows Runtime stream to a managed System.IO.Stream object with the specified buffer size because this Windows Runtime stream has been previously converted to a managed Stream object with a different buffer size. Ensure that t ...</summary>
        internal static string @InvalidOperation_CannotChangeBufferSizeOfWinRtStreamAdapter => GetResourceString("InvalidOperation_CannotChangeBufferSizeOfWinRtStreamAdapter");
        /// <summary>Cannot convert the specified Windows Runtime stream to a managed System.IO.Stream object without a buffer because this Windows Runtime stream has been previously converted to a managed Stream object with a buffer. Ensure that the 'bufferSize' argument matc ...</summary>
        internal static string @InvalidOperation_CannotChangeBufferSizeOfWinRtStreamAdapterToZero => GetResourceString("InvalidOperation_CannotChangeBufferSizeOfWinRtStreamAdapterToZero");
        /// <summary>Cannot call GetResults on this asynchronous info because the underlying operation has not completed.</summary>
        internal static string @InvalidOperation_CannotGetResultsFromIncompleteOperation => GetResourceString("InvalidOperation_CannotGetResultsFromIncompleteOperation");
        /// <summary>The 'Completed' handler delegate cannot be set more than once, but this handler has already been set.</summary>
        internal static string @InvalidOperation_CannotSetCompletionHanlderMoreThanOnce => GetResourceString("InvalidOperation_CannotSetCompletionHanlderMoreThanOnce");
        /// <summary>Cannot set the size of this stream because it cannot be written to.</summary>
        internal static string @InvalidOperation_CannotSetStreamSizeCannotWrite => GetResourceString("InvalidOperation_CannotSetStreamSizeCannotWrite");
        /// <summary>The specified state transition is illegal for the current state of this object.</summary>
        internal static string @InvalidOperation_IllegalStateChange => GetResourceString("InvalidOperation_IllegalStateChange");
        /// <summary>The asynchronous operation could not be completed.</summary>
        internal static string @InvalidOperation_InvalidAsyncCompletion => GetResourceString("InvalidOperation_InvalidAsyncCompletion");
        /// <summary>A callback for the same asynchronous IO operation was invoked more than once.</summary>
        internal static string @InvalidOperation_MultipleIOCompletionCallbackInvocation => GetResourceString("InvalidOperation_MultipleIOCompletionCallbackInvocation");
        /// <summary>The Task provider delegate specified for this IAsyncInfo instance returned a Task object that was not started. Task instances must be run immediately upon creation.</summary>
        internal static string @InvalidOperation_TaskProviderReturnedUnstartedTask => GetResourceString("InvalidOperation_TaskProviderReturnedUnstartedTask");
        /// <summary>This AsyncResult or Task corresponds to a different asynchronous operation ID than the one that invoked the completion callback.</summary>
        internal static string @InvalidOperation_UnexpectedAsyncOperationID => GetResourceString("InvalidOperation_UnexpectedAsyncOperationID");
        /// <summary>The specified underlying Task is not started. Task instances must be run immediately upon creation.</summary>
        internal static string @InvalidOperation_UnstartedTaskSpecified => GetResourceString("InvalidOperation_UnstartedTaskSpecified");
        /// <summary>Cannot seek to an absolute stream position that is larger than 2^63 - 1 bytes. (2^63 - 1 = 0x7FFFFFFFFFFFFFFF = Int64.MaxValue).</summary>
        internal static string @IO_CannotSeekBeyondInt64MaxValue => GetResourceString("IO_CannotSeekBeyondInt64MaxValue");
        /// <summary>This Windows Runtime stream is backed by a .NET Stream; its size cannot be set to a value that is larger than 2^63 - 1 bytes. (2^63 - 1 = 0x7FFFFFFFFFFFFFFF = Int64.MaxValue).</summary>
        internal static string @IO_CannotSetSizeBeyondInt64MaxValue => GetResourceString("IO_CannotSetSizeBeyondInt64MaxValue");
        /// <summary>An IO error occurred in the Windows runtime system.</summary>
        internal static string @IO_General => GetResourceString("IO_General");
        /// <summary>This Stream is backed by a Windows Runtime stream with a length that exceeds 2^63 - 1 bytes. Operations related to the stream's length or position cannot be performed on streams when the length exceeds 2^63 - 1 bytes. (2^63 - 1 = 0x7FFFFFFFFFFFFFFF = Int64 ...</summary>
        internal static string @IO_UnderlyingWinRTStreamTooLong_CannotUseLengthOrPosition => GetResourceString("IO_UnderlyingWinRTStreamTooLong_CannotUseLengthOrPosition");
        /// <summary>A native library routine was not found: {0}.</summary>
        internal static string @NotImplemented_NativeRoutineNotFound => GetResourceString("NotImplemented_NativeRoutineNotFound");
        /// <summary>Cannot use the specified Stream as a Windows Runtime IInputStream because this Stream is not readable.</summary>
        internal static string @NotSupported_CannotConvertNotReadableToInputStream => GetResourceString("NotSupported_CannotConvertNotReadableToInputStream");
        /// <summary>Cannot use the specified Stream as a Windows Runtime IRandomAccessStream because this Stream does not support seeking.</summary>
        internal static string @NotSupported_CannotConvertNotSeekableToRandomAccessStream => GetResourceString("NotSupported_CannotConvertNotSeekableToRandomAccessStream");
        /// <summary>Cannot use the specified Stream as a Windows Runtime IOutputStream because this Stream is not writable.</summary>
        internal static string @NotSupported_CannotConvertNotWritableToOutputStream => GetResourceString("NotSupported_CannotConvertNotWritableToOutputStream");
        /// <summary>This stream does not support read access.</summary>
        internal static string @NotSupported_CannotReadFromStream => GetResourceString("NotSupported_CannotReadFromStream");
        /// <summary>This stream does not support seeking.</summary>
        internal static string @NotSupported_CannotSeekInStream => GetResourceString("NotSupported_CannotSeekInStream");
        /// <summary>This stream does not support the Length property because it is not seekable.</summary>
        internal static string @NotSupported_CannotUseLength_StreamNotSeekable => GetResourceString("NotSupported_CannotUseLength_StreamNotSeekable");
        /// <summary>This stream does not support the Position property because it is not seekable.</summary>
        internal static string @NotSupported_CannotUsePosition_StreamNotSeekable => GetResourceString("NotSupported_CannotUsePosition_StreamNotSeekable");
        /// <summary>This stream does not support write access.</summary>
        internal static string @NotSupported_CannotWriteToStream => GetResourceString("NotSupported_CannotWriteToStream");
        /// <summary>This IRandomAccessStream does not support the {0} method because it requires cloning and this stream does not support cloning.</summary>
        internal static string @NotSupported_CloningNotSupported => GetResourceString("NotSupported_CloningNotSupported");
        /// <summary>The Windows Runtime stream that underlies this System.IO.Stream object has invoked an IO completion callback and specified null for the IAsyncInfo instance that describes the completed IO operation. This behavior is not supported because results cannot be  ...</summary>
        internal static string @NullReference_IOCompletionCallbackCannotProcessNullAsyncInfo => GetResourceString("NullReference_IOCompletionCallbackCannotProcessNullAsyncInfo");
        /// <summary>The task provider delegate used to create this asynchronous operation returned null, but a valid Task object was expected.</summary>
        internal static string @NullReference_TaskProviderReturnedNull => GetResourceString("NullReference_TaskProviderReturnedNull");
        /// <summary>The requested invocation is not permitted because this IAsyncInfo instance has already been closed.</summary>
        internal static string @ObjectDisposed_AsyncInfoIsClosed => GetResourceString("ObjectDisposed_AsyncInfoIsClosed");
        /// <summary>The requested operation cannot be performed because this stream has already been disposed.</summary>
        internal static string @ObjectDisposed_CannotPerformOperation => GetResourceString("ObjectDisposed_CannotPerformOperation");
        /// <summary>An error has occurred.</summary>
        internal static string @WinRtCOM_Error => GetResourceString("WinRtCOM_Error");
        /// <summary>Cannot access a closed stream.</summary>
        internal static string @ObjectDisposed_StreamClosed => GetResourceString("ObjectDisposed_StreamClosed");
        /// <summary>Stream does not support seeking.</summary>
        internal static string @NotSupported_UnseekableStream => GetResourceString("NotSupported_UnseekableStream");
        /// <summary>Stream does not support reading.</summary>
        internal static string @NotSupported_UnreadableStream => GetResourceString("NotSupported_UnreadableStream");
        /// <summary>Stream does not support writing.</summary>
        internal static string @NotSupported_UnwritableStream => GetResourceString("NotSupported_UnwritableStream");
        /// <summary>Invalid seek origin.</summary>
        internal static string @Argument_InvalidSeekOrigin => GetResourceString("Argument_InvalidSeekOrigin");
        /// <summary>Empty.</summary>
        internal static string @DirectUI_Empty => GetResourceString("DirectUI_Empty");
        /// <summary>Send is not supported in the Windows Runtime SynchronizationContext</summary>
        internal static string @InvalidOperation_SendNotSupportedOnWindowsRTSynchronizationContext => GetResourceString("InvalidOperation_SendNotSupportedOnWindowsRTSynchronizationContext");
        /// <summary>MemoryStream's internal buffer cannot be accessed.</summary>
        internal static string @UnauthorizedAccess_InternalBuffer => GetResourceString("UnauthorizedAccess_InternalBuffer");
        /// <summary>Inheritable is not a supported option.</summary>
        internal static string @NotSupported_Inheritable => GetResourceString("NotSupported_Inheritable");
        /// <summary>Encrypted is not a supported option.</summary>
        internal static string @NotSupported_Encrypted => GetResourceString("NotSupported_Encrypted");
        /// <summary>Unable to find the specified file.</summary>
        internal static string @IO_FileNotFound => GetResourceString("IO_FileNotFound");
        /// <summary>Could not find file '{0}'.</summary>
        internal static string @IO_FileNotFound_FileName => GetResourceString("IO_FileNotFound_FileName");
        /// <summary>Could not find a part of the path.</summary>
        internal static string @IO_PathNotFound_NoPathName => GetResourceString("IO_PathNotFound_NoPathName");
        /// <summary>Could not find a part of the path '{0}'.</summary>
        internal static string @IO_PathNotFound_Path => GetResourceString("IO_PathNotFound_Path");
        /// <summary>Access to the path is denied.</summary>
        internal static string @UnauthorizedAccess_IODenied_NoPathName => GetResourceString("UnauthorizedAccess_IODenied_NoPathName");
        /// <summary>Access to the path '{0}' is denied.</summary>
        internal static string @UnauthorizedAccess_IODenied_Path => GetResourceString("UnauthorizedAccess_IODenied_Path");
        /// <summary>Cannot create '{0}' because a file or directory with the same name already exists.</summary>
        internal static string @IO_AlreadyExists_Name => GetResourceString("IO_AlreadyExists_Name");
        /// <summary>The specified file name or path is too long, or a component of the specified path is too long.</summary>
        internal static string @IO_PathTooLong => GetResourceString("IO_PathTooLong");
        /// <summary>The process cannot access the file '{0}' because it is being used by another process.</summary>
        internal static string @IO_SharingViolation_File => GetResourceString("IO_SharingViolation_File");
        /// <summary>The process cannot access the file because it is being used by another process.</summary>
        internal static string @IO_SharingViolation_NoFileName => GetResourceString("IO_SharingViolation_NoFileName");
        /// <summary>The file '{0}' already exists.</summary>
        internal static string @IO_FileExists_Name => GetResourceString("IO_FileExists_Name");
        /// <summary>The path '{0}' is too long, or a component of the specified path is too long.</summary>
        internal static string @IO_PathTooLong_Path => GetResourceString("IO_PathTooLong_Path");
        /// <summary>Windows Runtime (WinRT) is not supported on this platform.</summary>
        internal static string @PlatformNotSupported_WindowsRuntime => GetResourceString("PlatformNotSupported_WindowsRuntime");

        // This method is used to decide if we need to append the exception message parameters to the message when calling SR.Format. 
        // by default it returns false.
        // Native code generators can replace the value this returns based on user input at the time of native code generation.
        // Marked as NoInlining because if this is used in an AoT compiled app that is not compiled into a single file, the user
        // could compile each module with a different setting for this. We want to make sure there's a consistent behavior
        // that doesn't depend on which native module this method got inlined into.
        [MethodImpl(MethodImplOptions.NoInlining)]
        private static bool UsingResourceKeys() => false;

        internal static string GetResourceString( string resourceKey, string? defaultString = null ) {
            if ( UsingResourceKeys() ) {
                return defaultString ?? resourceKey;
            }

            string? resourceString = null;
            try {
                resourceString = ResourceManager.GetString(resourceKey);
            } catch ( MissingManifestResourceException ) { }

            if ( defaultString != null && resourceKey.Equals(resourceString) ) {
                return defaultString;
            }

            return resourceString!; // only null if missing resources
        }

        internal static string Format( string resourceFormat, object? p1 ) {
            if ( UsingResourceKeys() ) {
                return string.Join(", ", resourceFormat, p1);
            }

            return string.Format(resourceFormat, p1);
        }

        internal static string Format( string resourceFormat, object? p1, object? p2 ) {
            if ( UsingResourceKeys() ) {
                return string.Join(", ", resourceFormat, p1, p2);
            }

            return string.Format(resourceFormat, p1, p2);
        }

        internal static string Format( string resourceFormat, object? p1, object? p2, object? p3 ) {
            if ( UsingResourceKeys() ) {
                return string.Join(", ", resourceFormat, p1, p2, p3);
            }

            return string.Format(resourceFormat, p1, p2, p3);
        }

        internal static string Format( string resourceFormat, params object?[]? args ) {
            if ( args != null ) {
                if ( UsingResourceKeys() ) {
                    return resourceFormat + ", " + string.Join(", ", args);
                }

                return string.Format(resourceFormat, args);
            }

            return resourceFormat;
        }

        internal static string Format( IFormatProvider? provider, string resourceFormat, object? p1 ) {
            if ( UsingResourceKeys() ) {
                return string.Join(", ", resourceFormat, p1);
            }

            return string.Format(provider, resourceFormat, p1);
        }

        internal static string Format( IFormatProvider? provider, string resourceFormat, object? p1, object? p2 ) {
            if ( UsingResourceKeys() ) {
                return string.Join(", ", resourceFormat, p1, p2);
            }

            return string.Format(provider, resourceFormat, p1, p2);
        }

        internal static string Format( IFormatProvider? provider, string resourceFormat, object? p1, object? p2, object? p3 ) {
            if ( UsingResourceKeys() ) {
                return string.Join(", ", resourceFormat, p1, p2, p3);
            }

            return string.Format(provider, resourceFormat, p1, p2, p3);
        }

        internal static string Format( IFormatProvider? provider, string resourceFormat, params object?[]? args ) {
            if ( args != null ) {
                if ( UsingResourceKeys() ) {
                    return resourceFormat + ", " + string.Join(", ", args);
                }

                return string.Format(provider, resourceFormat, args);
            }

            return resourceFormat;
        }
    }
}
