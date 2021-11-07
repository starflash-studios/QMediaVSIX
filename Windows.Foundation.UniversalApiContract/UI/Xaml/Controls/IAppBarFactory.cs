// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1632045265, 36453, 17355, 146, 215, 142, 238, 23, 81, 95, 141)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AppBar))]
  internal interface IAppBarFactory
  {
    AppBar CreateInstance(object baseInterface, out object innerInterface);
  }
}
