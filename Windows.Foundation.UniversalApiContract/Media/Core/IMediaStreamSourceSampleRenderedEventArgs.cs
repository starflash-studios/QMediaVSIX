// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceSampleRenderedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2640935685, 54514, 19578, 157, 254, 141, 108, 208, 179, 238, 132)]
  [ExclusiveTo(typeof (MediaStreamSourceSampleRenderedEventArgs))]
  internal interface IMediaStreamSourceSampleRenderedEventArgs
  {
    TimeSpan SampleLag { get; }
  }
}
