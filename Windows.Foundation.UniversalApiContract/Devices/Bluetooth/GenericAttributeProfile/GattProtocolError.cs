// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattProtocolError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>This class contains byte values for GATT protocol errors.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGattProtocolErrorStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 1)]
  public static class GattProtocolError
  {
    /// <summary>Gets the byte value for an invalid handle error.</summary>
    /// <returns>The byte value for an invalid handle error.</returns>
    public static extern byte InvalidHandle { [MethodImpl] get; }

    /// <summary>Gets the byte value for a read not permitted error.</summary>
    /// <returns>The byte value for a read not permitted error.</returns>
    public static extern byte ReadNotPermitted { [MethodImpl] get; }

    /// <summary>Gets the byte value for a write not permitted error.</summary>
    /// <returns>The byte value for a write not permitted error.</returns>
    public static extern byte WriteNotPermitted { [MethodImpl] get; }

    /// <summary>Gets the byte value for an invalid PDU error.</summary>
    /// <returns>The byte value for an invalid PDU error.</returns>
    public static extern byte InvalidPdu { [MethodImpl] get; }

    /// <summary>Gets the byte value for an insufficient authentication error.</summary>
    /// <returns>The byte value for an insufficient authentication error.</returns>
    public static extern byte InsufficientAuthentication { [MethodImpl] get; }

    /// <summary>Gets the byte value for a request not supported error.</summary>
    /// <returns>The byte value for a request not supported error.</returns>
    public static extern byte RequestNotSupported { [MethodImpl] get; }

    /// <summary>Gets the byte value for an invalid offset error.</summary>
    /// <returns>The byte value for an invalid offset error.</returns>
    public static extern byte InvalidOffset { [MethodImpl] get; }

    /// <summary>Gets the byte value for an insufficient authorization error.</summary>
    /// <returns>The byte value for an insufficient authorization error.</returns>
    public static extern byte InsufficientAuthorization { [MethodImpl] get; }

    /// <summary>Gets the byte value for a prepare queue full error.</summary>
    /// <returns>The byte value for a prepare queue full error.</returns>
    public static extern byte PrepareQueueFull { [MethodImpl] get; }

    /// <summary>Gets the byte value for an attribute not found error.</summary>
    /// <returns>The byte value for an attribute not found error.</returns>
    public static extern byte AttributeNotFound { [MethodImpl] get; }

    /// <summary>Gets the byte value for an attribute not long error.</summary>
    /// <returns>The byte value for an attribute not long error.</returns>
    public static extern byte AttributeNotLong { [MethodImpl] get; }

    /// <summary>Gets the byte value for an insufficient encryption key size error.</summary>
    /// <returns>The byte value for an insufficient encryption key size error.</returns>
    public static extern byte InsufficientEncryptionKeySize { [MethodImpl] get; }

    /// <summary>Gets the byte value for an invalid attribute value length error.</summary>
    /// <returns>The byte value for an invalid attribute value length error.</returns>
    public static extern byte InvalidAttributeValueLength { [MethodImpl] get; }

    /// <summary>Gets the byte value for an unlikely error.</summary>
    /// <returns>The byte value for an unsupported group type error.</returns>
    public static extern byte UnlikelyError { [MethodImpl] get; }

    /// <summary>Gets the byte value for an insufficient encryption error.</summary>
    /// <returns>The byte value for an insufficient encryption error.</returns>
    public static extern byte InsufficientEncryption { [MethodImpl] get; }

    /// <summary>Gets the byte value for an unsupported group type error.</summary>
    /// <returns>The byte value for an unsupported group type error.</returns>
    public static extern byte UnsupportedGroupType { [MethodImpl] get; }

    /// <summary>Gets the byte value for an insufficient resources error.</summary>
    /// <returns>The byte value for an insufficient resources error.</returns>
    public static extern byte InsufficientResources { [MethodImpl] get; }
  }
}
