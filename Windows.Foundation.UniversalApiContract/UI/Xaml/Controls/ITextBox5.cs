// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBox5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (TextBox))]
  [WebHostHidden]
  [Guid(905564097, 16758, 17652, 183, 86, 233, 204, 196, 57, 152, 5)]
  internal interface ITextBox5
  {
    SolidColorBrush SelectionHighlightColorWhenNotFocused { get; set; }
  }
}
