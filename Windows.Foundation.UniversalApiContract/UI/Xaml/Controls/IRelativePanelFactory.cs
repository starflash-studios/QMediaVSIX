// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRelativePanelFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (RelativePanel))]
  [Guid(2220890428, 13851, 17594, 161, 126, 184, 76, 157, 205, 199, 114)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRelativePanelFactory
  {
    RelativePanel CreateInstance(object baseInterface, out object innerInterface);
  }
}
