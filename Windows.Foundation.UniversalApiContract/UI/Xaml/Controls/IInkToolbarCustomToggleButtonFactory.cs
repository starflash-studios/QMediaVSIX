// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarCustomToggleButtonFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (InkToolbarCustomToggleButton))]
  [WebHostHidden]
  [Guid(1241528141, 19666, 20185, 134, 62, 131, 184, 207, 63, 210, 175)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IInkToolbarCustomToggleButtonFactory
  {
    InkToolbarCustomToggleButton CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
