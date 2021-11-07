// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IImage2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Casting;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Image))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4098167198, 34847, 18619, 135, 58, 100, 65, 124, 164, 240, 2)]
  internal interface IImage2
  {
    CastingSource GetAsCastingSource();
  }
}
