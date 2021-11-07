// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattProtocolErrorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(3393635781, 3788, 18441, 190, 163, 207, 121, 188, 153, 30, 55)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (GattProtocolError))]
  internal interface IGattProtocolErrorStatics
  {
    byte InvalidHandle { get; }

    byte ReadNotPermitted { get; }

    byte WriteNotPermitted { get; }

    byte InvalidPdu { get; }

    byte InsufficientAuthentication { get; }

    byte RequestNotSupported { get; }

    byte InvalidOffset { get; }

    byte InsufficientAuthorization { get; }

    byte PrepareQueueFull { get; }

    byte AttributeNotFound { get; }

    byte AttributeNotLong { get; }

    byte InsufficientEncryptionKeySize { get; }

    byte InvalidAttributeValueLength { get; }

    byte UnlikelyError { get; }

    byte InsufficientEncryption { get; }

    byte UnsupportedGroupType { get; }

    byte InsufficientResources { get; }
  }
}
