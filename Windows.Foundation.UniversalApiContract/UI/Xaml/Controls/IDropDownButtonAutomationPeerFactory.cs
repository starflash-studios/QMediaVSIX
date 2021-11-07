// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDropDownButtonAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3099871666, 25428, 23564, 158, 149, 224, 201, 154, 41, 58, 68)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (DropDownButtonAutomationPeer))]
  [WebHostHidden]
  internal interface IDropDownButtonAutomationPeerFactory
  {
    DropDownButtonAutomationPeer CreateInstance(
      DropDownButton owner,
      object baseInterface,
      out object innerInterface);
  }
}
