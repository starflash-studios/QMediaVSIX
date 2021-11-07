// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPivotStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Pivot))]
  [Guid(3612445405, 48757, 16419, 141, 235, 198, 81, 60, 49, 146, 163)]
  internal interface IPivotStatics2
  {
    DependencyProperty LeftHeaderProperty { get; }

    DependencyProperty LeftHeaderTemplateProperty { get; }

    DependencyProperty RightHeaderProperty { get; }

    DependencyProperty RightHeaderTemplateProperty { get; }
  }
}
