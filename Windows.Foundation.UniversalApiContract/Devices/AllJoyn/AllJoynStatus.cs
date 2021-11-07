// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Defines a collection of properties used to convey meaning for AllJoyn status codes. For possible status values, refer to the AllJoyn standard documentation.</summary>
  [Static(typeof (IAllJoynStatusStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("AllJoynStatus has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class AllJoynStatus
  {
    /// <summary>Operation successful.</summary>
    /// <returns>The relevant AllJoyn status code.</returns>
    public static extern int Ok { [Deprecated("AllJoynStatus has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The operation has failed.</summary>
    /// <returns>The relevant AllJoyn status code.</returns>
    public static extern int Fail { [Deprecated("AllJoynStatus has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The operation timed out.</summary>
    /// <returns>The relevant AllJoyn status code.</returns>
    public static extern int OperationTimedOut { [Deprecated("AllJoynStatus has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The Producer end of the session connection was closed.</summary>
    /// <returns>The relevant AllJoyn status code.</returns>
    public static extern int OtherEndClosed { [Deprecated("AllJoynStatus has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The connection to the session was refused.</summary>
    /// <returns>The relevant AllJoyn status code.</returns>
    public static extern int ConnectionRefused { [Deprecated("AllJoynStatus has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Indicates that authentication could not be completed.</summary>
    /// <returns>The relevant AllJoyn status code.</returns>
    public static extern int AuthenticationFailed { [Deprecated("AllJoynStatus has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Authentication was rejected by the advertising app.</summary>
    /// <returns>The relevant AllJoyn status code.</returns>
    public static extern int AuthenticationRejectedByUser { [Deprecated("AllJoynStatus has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The SSL connection has failed.</summary>
    /// <returns>The relevant AllJoyn status code.</returns>
    public static extern int SslConnectFailed { [Deprecated("AllJoynStatus has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The SSL verification failed. Review provided SSL credentials.</summary>
    /// <returns>The relevant AllJoyn status code.</returns>
    public static extern int SslIdentityVerificationFailed { [Deprecated("AllJoynStatus has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Insufficient security provided for session connections.</summary>
    /// <returns>The relevant AllJoyn status code.</returns>
    public static extern int InsufficientSecurity { [Deprecated("AllJoynStatus has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Function call argument 1 is invalid.</summary>
    /// <returns>The relevant AllJoyn status code.</returns>
    public static extern int InvalidArgument1 { [Deprecated("AllJoynStatus has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Function call argument 2 is invalid.</summary>
    /// <returns>The relevant AllJoyn status code.</returns>
    public static extern int InvalidArgument2 { [Deprecated("AllJoynStatus has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Function call argument 3 is invalid.</summary>
    /// <returns>The relevant AllJoyn status code.</returns>
    public static extern int InvalidArgument3 { [Deprecated("AllJoynStatus has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Function call argument 4 is invalid.</summary>
    /// <returns>The relevant AllJoyn status code.</returns>
    public static extern int InvalidArgument4 { [Deprecated("AllJoynStatus has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Function call argument 5 is invalid.</summary>
    /// <returns>The relevant AllJoyn status code.</returns>
    public static extern int InvalidArgument5 { [Deprecated("AllJoynStatus has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Function call argument 6 is invalid.</summary>
    /// <returns>The relevant AllJoyn status code.</returns>
    public static extern int InvalidArgument6 { [Deprecated("AllJoynStatus has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Function call argument 7 is invalid.</summary>
    /// <returns>The relevant AllJoyn status code.</returns>
    public static extern int InvalidArgument7 { [Deprecated("AllJoynStatus has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Function call argument 8 is invalid.</summary>
    /// <returns>The relevant AllJoyn status code.</returns>
    public static extern int InvalidArgument8 { [Deprecated("AllJoynStatus has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
