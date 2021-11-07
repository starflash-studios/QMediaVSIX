// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSourceStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(4007748004, 32531, 18582, 184, 203, 223, 13, 229, 188, 185, 241)]
  [ExclusiveTo(typeof (MediaSource))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IMediaSourceStatics2
  {
    MediaSource CreateFromMediaBinder(MediaBinder binder);
  }
}
