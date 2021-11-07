// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBox7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(3662221817, 65505, 19562, 172, 109, 27, 74, 23, 76, 207, 128)]
  [ExclusiveTo(typeof (TextBox))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface ITextBox7
  {
    HandwritingView HandwritingView { get; set; }

    bool IsHandwritingViewEnabled { get; set; }
  }
}
