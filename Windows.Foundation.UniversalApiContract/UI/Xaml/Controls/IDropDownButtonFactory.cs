// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDropDownButtonFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (DropDownButton))]
  [Guid(228559541, 59149, 21181, 156, 160, 54, 206, 236, 170, 100, 42)]
  [WebHostHidden]
  internal interface IDropDownButtonFactory
  {
    DropDownButton CreateInstance(object baseInterface, out object innerInterface);
  }
}
