// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsMessageClass
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>This enumerated type specifies the message class of a message. The message class typically originates on the network, not the mobile device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SmsMessageClass
  {
    /// <summary>No class was specified.</summary>
    None,
    /// <summary>Message should be immediately displayed.</summary>
    Class0,
    /// <summary>Mobile equipment (ME) specific message.</summary>
    Class1,
    /// <summary>SIM specific message.</summary>
    Class2,
    /// <summary>Terminal equipment (TE) specific message. Note that this message type is not currently supported.</summary>
    Class3,
  }
}
