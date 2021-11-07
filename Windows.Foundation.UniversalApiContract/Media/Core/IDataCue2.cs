// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IDataCue2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(3159759637, 38386, 18920, 150, 241, 141, 213, 218, 198, 141, 147)]
  [ExclusiveTo(typeof (DataCue))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IDataCue2 : IDataCue, IMediaCue
  {
    PropertySet Properties { get; }
  }
}
