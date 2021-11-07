// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IToggleSplitButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(681057073, 36472, 22284, 190, 187, 104, 88, 20, 72, 90, 233)]
  [ExclusiveTo(typeof (ToggleSplitButton))]
  [WebHostHidden]
  internal interface IToggleSplitButton
  {
    bool IsChecked { get; set; }

    event TypedEventHandler<ToggleSplitButton, ToggleSplitButtonIsCheckedChangedEventArgs> IsCheckedChanged;
  }
}
