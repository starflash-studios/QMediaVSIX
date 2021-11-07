// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMenuBarItemFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(3975704418, 50068, 20706, 165, 104, 23, 175, 140, 242, 104, 116)]
  [ExclusiveTo(typeof (MenuBarItem))]
  [WebHostHidden]
  internal interface IMenuBarItemFactory
  {
    MenuBarItem CreateInstance(object baseInterface, out object innerInterface);
  }
}
