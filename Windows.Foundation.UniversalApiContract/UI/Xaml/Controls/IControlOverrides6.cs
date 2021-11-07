// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControlOverrides6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(3784624490, 55500, 17209, 160, 225, 46, 156, 66, 8, 121, 236)]
  [ExclusiveTo(typeof (Control))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IControlOverrides6
  {
    void OnPreviewKeyDown(KeyRoutedEventArgs e);

    void OnPreviewKeyUp(KeyRoutedEventArgs e);

    void OnCharacterReceived(CharacterReceivedRoutedEventArgs e);
  }
}
