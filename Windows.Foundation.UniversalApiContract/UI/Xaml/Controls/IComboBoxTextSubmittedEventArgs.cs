// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IComboBoxTextSubmittedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3412692155, 26745, 21902, 175, 130, 223, 29, 8, 246, 42, 250)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ComboBoxTextSubmittedEventArgs))]
  internal interface IComboBoxTextSubmittedEventArgs
  {
    string Text { get; }

    bool Handled { get; set; }
  }
}
