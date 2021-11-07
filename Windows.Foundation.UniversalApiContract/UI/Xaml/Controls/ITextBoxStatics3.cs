// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBoxStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(235931072, 4277, 16630, 146, 194, 206, 19, 75, 13, 52, 87)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TextBox))]
  internal interface ITextBoxStatics3
  {
    DependencyProperty DesiredCandidateWindowAlignmentProperty { get; }

    DependencyProperty TextReadingOrderProperty { get; }
  }
}
