// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFrameStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Frame))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3584880873, 55655, 18203, 132, 89, 200, 175, 67, 65, 81, 27)]
  internal interface IFrameStatics
  {
    DependencyProperty CacheSizeProperty { get; }

    DependencyProperty CanGoBackProperty { get; }

    DependencyProperty CanGoForwardProperty { get; }

    DependencyProperty CurrentSourcePageTypeProperty { get; }

    DependencyProperty SourcePageTypeProperty { get; }

    DependencyProperty BackStackDepthProperty { get; }
  }
}
