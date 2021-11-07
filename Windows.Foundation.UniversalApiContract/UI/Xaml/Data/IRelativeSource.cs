// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IRelativeSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ExclusiveTo(typeof (RelativeSource))]
  [WebHostHidden]
  [Guid(597151364, 10274, 18490, 180, 153, 208, 240, 49, 224, 108, 107)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRelativeSource
  {
    RelativeSourceMode Mode { get; set; }
  }
}
