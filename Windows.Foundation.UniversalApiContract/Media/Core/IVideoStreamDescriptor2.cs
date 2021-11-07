// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IVideoStreamDescriptor2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(2335206928, 17726, 16520, 131, 45, 195, 111, 164, 249, 74, 243)]
  [ExclusiveTo(typeof (VideoStreamDescriptor))]
  internal interface IVideoStreamDescriptor2
  {
    VideoStreamDescriptor Copy();
  }
}
