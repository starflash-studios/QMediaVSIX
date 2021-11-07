// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IResponseInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (ResponseInformation))]
  [Guid(4173044242, 63251, 18322, 139, 104, 217, 210, 151, 249, 29, 46)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IResponseInformation
  {
    bool IsResumable { get; }

    Uri ActualUri { get; }

    uint StatusCode { get; }

    IMapView<string, string> Headers { get; }
  }
}
