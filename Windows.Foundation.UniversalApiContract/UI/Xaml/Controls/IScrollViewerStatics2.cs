// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IScrollViewerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(869345709, 36222, 17056, 191, 50, 144, 92, 204, 208, 77, 65)]
  [ExclusiveTo(typeof (ScrollViewer))]
  [WebHostHidden]
  internal interface IScrollViewerStatics2
  {
    DependencyProperty TopLeftHeaderProperty { get; }

    DependencyProperty LeftHeaderProperty { get; }

    DependencyProperty TopHeaderProperty { get; }
  }
}
