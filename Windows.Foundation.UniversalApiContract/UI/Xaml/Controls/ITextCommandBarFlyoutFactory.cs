// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextCommandBarFlyoutFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [Guid(458823896, 45062, 24269, 171, 114, 111, 219, 72, 171, 193, 244)]
  [ExclusiveTo(typeof (TextCommandBarFlyout))]
  internal interface ITextCommandBarFlyoutFactory
  {
    TextCommandBarFlyout CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
