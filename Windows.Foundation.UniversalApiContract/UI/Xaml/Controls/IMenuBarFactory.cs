// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMenuBarFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(3697385040, 29370, 20799, 128, 170, 221, 208, 147, 130, 93, 222)]
  [ExclusiveTo(typeof (MenuBar))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IMenuBarFactory
  {
    MenuBar CreateInstance(object baseInterface, out object innerInterface);
  }
}
