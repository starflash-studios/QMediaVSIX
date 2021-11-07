// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IParagraphStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ExclusiveTo(typeof (Paragraph))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(4010313882, 21339, 20044, 141, 132, 40, 59, 51, 233, 138, 55)]
  internal interface IParagraphStatics
  {
    DependencyProperty TextIndentProperty { get; }
  }
}
