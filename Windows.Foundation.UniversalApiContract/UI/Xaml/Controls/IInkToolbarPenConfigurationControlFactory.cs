// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarPenConfigurationControlFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InkToolbarPenConfigurationControl))]
  [WebHostHidden]
  [Guid(1743807982, 62951, 18155, 145, 135, 141, 60, 163, 175, 137, 27)]
  internal interface IInkToolbarPenConfigurationControlFactory
  {
    InkToolbarPenConfigurationControl CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
