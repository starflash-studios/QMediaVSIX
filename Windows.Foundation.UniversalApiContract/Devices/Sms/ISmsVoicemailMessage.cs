// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsVoicemailMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmsVoicemailMessage))]
  [Guid(656056486, 38321, 17663, 188, 184, 184, 253, 215, 224, 139, 195)]
  internal interface ISmsVoicemailMessage : ISmsMessageBase
  {
    DateTime Timestamp { get; }

    string To { get; }

    string Body { get; }

    IReference<int> MessageCount { get; }
  }
}
