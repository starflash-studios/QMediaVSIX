// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBar3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2552954911, 29998, 20090, 176, 85, 84, 128, 44, 158, 167, 73)]
  [ExclusiveTo(typeof (AppBar))]
  [WebHostHidden]
  internal interface IAppBar3
  {
    AppBarTemplateSettings TemplateSettings { get; }

    event EventHandler<object> Opening;

    event EventHandler<object> Closing;
  }
}
