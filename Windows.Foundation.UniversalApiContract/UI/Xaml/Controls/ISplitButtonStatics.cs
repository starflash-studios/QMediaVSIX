// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISplitButtonStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (SplitButton))]
  [Guid(2381347457, 2847, 24233, 190, 66, 21, 42, 185, 164, 188, 94)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ISplitButtonStatics
  {
    DependencyProperty FlyoutProperty { get; }

    DependencyProperty CommandProperty { get; }

    DependencyProperty CommandParameterProperty { get; }
  }
}
