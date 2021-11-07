// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControl5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [Guid(1589334485, 40536, 18871, 188, 45, 1, 85, 255, 17, 134, 100)]
  [ExclusiveTo(typeof (Control))]
  internal interface IControl5
  {
    Uri DefaultStyleResourceUri { get; set; }
  }
}
