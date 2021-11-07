// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ITickBar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (TickBar))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2571535354, 61942, 18557, 165, 172, 193, 89, 33, 191, 169, 149)]
  [WebHostHidden]
  internal interface ITickBar
  {
    Brush Fill { get; set; }
  }
}
