// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceSwitchStreamsRequestDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaStreamSourceSwitchStreamsRequestDeferral))]
  [Guid(3202603061, 42245, 20378, 185, 67, 43, 140, 177, 180, 187, 217)]
  internal interface IMediaStreamSourceSwitchStreamsRequestDeferral
  {
    void Complete();
  }
}
