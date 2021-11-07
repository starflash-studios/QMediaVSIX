// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaBinder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(729694378, 56839, 16975, 131, 241, 241, 222, 70, 196, 250, 46)]
  [ExclusiveTo(typeof (MediaBinder))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IMediaBinder
  {
    event TypedEventHandler<MediaBinder, MediaBindingEventArgs> Binding;

    string Token { get; set; }

    MediaSource Source { get; }
  }
}
