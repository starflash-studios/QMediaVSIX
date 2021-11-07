// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBoxTextChangingEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(3228712260, 21414, 16735, 169, 129, 80, 223, 175, 27, 236, 190)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (TextBoxTextChangingEventArgs))]
  internal interface ITextBoxTextChangingEventArgs2
  {
    bool IsContentChanging { get; }
  }
}
