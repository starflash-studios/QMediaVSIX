// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsStatusMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [Guid(3872555842, 46859, 18039, 147, 121, 201, 120, 63, 223, 248, 244)]
  [ExclusiveTo(typeof (SmsStatusMessage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmsStatusMessage : ISmsMessageBase
  {
    string To { get; }

    string From { get; }

    string Body { get; }

    int Status { get; }

    int MessageReferenceNumber { get; }

    DateTime ServiceCenterTimestamp { get; }

    DateTime DischargeTime { get; }
  }
}
