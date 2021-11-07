// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarOverrides
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4026787042, 31503, 20298, 151, 13, 174, 138, 14, 170, 155, 112)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AppBar))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppBarOverrides
  {
    void OnClosed(object e);

    void OnOpened(object e);
  }
}
