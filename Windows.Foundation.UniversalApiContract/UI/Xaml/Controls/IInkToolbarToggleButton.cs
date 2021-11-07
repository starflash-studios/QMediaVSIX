// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarToggleButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (InkToolbarToggleButton))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3030546682, 62960, 19231, 190, 176, 11, 138, 41, 144, 90, 74)]
  internal interface IInkToolbarToggleButton
  {
    InkToolbarToggle ToggleKind { get; }
  }
}
