// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceClosedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (MediaStreamSourceClosedEventArgs))]
  [Guid(3448536754, 18454, 20004, 136, 240, 73, 30, 247, 56, 100, 6)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaStreamSourceClosedEventArgs
  {
    MediaStreamSourceClosedRequest Request { get; }
  }
}
