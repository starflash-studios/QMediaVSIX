// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsMessageType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>This enumerated type defines the format of the SMS message.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SmsMessageType
  {
    /// <summary>The SMS message is in binary format.</summary>
    Binary,
    /// <summary>The SMS message is in text format.</summary>
    Text,
    /// <summary>A WAP Push message (an MMS message, for example). This value is supported on UWP app and Windows Phone 8.x app on Windows 10.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Wap,
    /// <summary>An application-directed message (a visual voicemail message on a specific port, for example). This value is supported on UWP app and Windows Phone 8.x app on Windows 10.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] App,
    /// <summary>A cell broadcast message. This value is supported on UWP app and Windows Phone 8.x app on Windows 10.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Broadcast,
    /// <summary>A legacy voicemail message waiting indication message.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Voicemail,
    /// <summary>A send status message. This value is supported on UWP app and Windows Phone 8.x app on Windows 10.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Status,
  }
}
