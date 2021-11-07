// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IInputPaneStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (InputPane))]
  [Guid(459494043, 55788, 17713, 132, 69, 113, 186, 185, 251, 130, 142)]
  internal interface IInputPaneStatics2
  {
    InputPane GetForUIContext(UIContext context);
  }
}
