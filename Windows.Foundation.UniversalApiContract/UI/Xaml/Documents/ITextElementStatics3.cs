// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextElementStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3488599983, 4001, 17900, 154, 78, 155, 51, 102, 77, 200, 177)]
  [ExclusiveTo(typeof (TextElement))]
  internal interface ITextElementStatics3
  {
    DependencyProperty AllowFocusOnInteractionProperty { get; }

    DependencyProperty AccessKeyProperty { get; }

    DependencyProperty ExitDisplayModeOnAccessKeyInvokedProperty { get; }
  }
}
