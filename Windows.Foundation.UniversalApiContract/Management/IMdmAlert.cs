// Decompiled with JetBrains decompiler
// Type: Windows.Management.IMdmAlert
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management
{
  [ExclusiveTo(typeof (MdmAlert))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2969289511, 10433, 19282, 165, 72, 197, 128, 124, 175, 112, 182)]
  internal interface IMdmAlert
  {
    string Data { get; set; }

    MdmAlertDataType Format { get; set; }

    MdmAlertMark Mark { get; set; }

    string Source { get; set; }

    uint Status { get; }

    string Target { get; set; }

    string Type { get; set; }
  }
}
