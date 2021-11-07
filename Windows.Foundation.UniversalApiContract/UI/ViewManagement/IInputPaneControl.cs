// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IInputPaneControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (InputPane))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(143372879, 38447, 18589, 170, 110, 198, 190, 26, 10, 110, 82)]
  internal interface IInputPaneControl
  {
    bool Visible { get; set; }
  }
}
