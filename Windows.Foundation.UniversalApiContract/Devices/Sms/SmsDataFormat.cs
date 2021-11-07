// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsDataFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>This enumerated type identifies the format of a given protocol description unit (PDU) buffer.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SmsDataFormat
  {
    /// <summary>The data format is unknown.</summary>
    Unknown,
    /// <summary>The data format is CDMA WMT format of type submit.</summary>
    CdmaSubmit,
    /// <summary>The data format is GSM of type submit.</summary>
    GsmSubmit,
    /// <summary>The data format is CDMA WMT format of type deliver.</summary>
    CdmaDeliver,
    /// <summary>The data format is GSM of type deliver.</summary>
    GsmDeliver,
  }
}
