// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IBounceEaseStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (BounceEase))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3228573090, 20339, 16841, 178, 203, 46, 163, 16, 81, 7, 255)]
  [WebHostHidden]
  internal interface IBounceEaseStatics
  {
    DependencyProperty BouncesProperty { get; }

    DependencyProperty BouncinessProperty { get; }
  }
}
