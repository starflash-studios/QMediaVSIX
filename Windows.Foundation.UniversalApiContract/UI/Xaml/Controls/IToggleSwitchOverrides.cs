// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IToggleSwitchOverrides
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3218112339, 63690, 20039, 148, 158, 158, 128, 66, 155, 61, 22)]
  [ExclusiveTo(typeof (ToggleSwitch))]
  internal interface IToggleSwitchOverrides
  {
    void OnToggled();

    void OnOnContentChanged(object oldContent, object newContent);

    void OnOffContentChanged(object oldContent, object newContent);

    void OnHeaderChanged(object oldContent, object newContent);
  }
}
