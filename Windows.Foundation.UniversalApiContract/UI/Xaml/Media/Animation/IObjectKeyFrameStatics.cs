// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IObjectKeyFrameStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(752265984, 21273, 17030, 142, 237, 78, 117, 94, 160, 207, 156)]
  [ExclusiveTo(typeof (ObjectKeyFrame))]
  internal interface IObjectKeyFrameStatics
  {
    DependencyProperty ValueProperty { get; }

    DependencyProperty KeyTimeProperty { get; }
  }
}
