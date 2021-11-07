// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarElementContainerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (AppBarElementContainer))]
  [Guid(3955161152, 51013, 23151, 134, 113, 154, 65, 235, 33, 150, 231)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IAppBarElementContainerStatics
  {
    DependencyProperty IsCompactProperty { get; }

    DependencyProperty IsInOverflowProperty { get; }

    DependencyProperty DynamicOverflowOrderProperty { get; }
  }
}
