// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarOverrides3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1093385160, 20944, 19273, 171, 98, 163, 221, 107, 220, 178, 152)]
  [ExclusiveTo(typeof (AppBar))]
  internal interface IAppBarOverrides3
  {
    void OnClosing(object e);

    void OnOpening(object e);
  }
}
