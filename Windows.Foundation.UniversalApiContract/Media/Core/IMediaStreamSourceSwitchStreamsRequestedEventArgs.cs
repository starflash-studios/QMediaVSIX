// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceSwitchStreamsRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(1109404530, 28321, 18039, 152, 30, 53, 10, 13, 164, 18, 170)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaStreamSourceSwitchStreamsRequestedEventArgs))]
  internal interface IMediaStreamSourceSwitchStreamsRequestedEventArgs
  {
    MediaStreamSourceSwitchStreamsRequest Request { get; }
  }
}
