// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFrameStatics5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1405655845, 61664, 22769, 160, 109, 68, 16, 117, 145, 79, 248)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Frame))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IFrameStatics5
  {
    DependencyProperty IsNavigationStackEnabledProperty { get; }
  }
}
