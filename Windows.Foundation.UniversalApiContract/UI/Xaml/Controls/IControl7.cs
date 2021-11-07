// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControl7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(894491617, 58721, 22836, 163, 239, 125, 184, 191, 110, 59, 69)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Control))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IControl7
  {
    BackgroundSizing BackgroundSizing { get; set; }

    CornerRadius CornerRadius { get; set; }
  }
}
