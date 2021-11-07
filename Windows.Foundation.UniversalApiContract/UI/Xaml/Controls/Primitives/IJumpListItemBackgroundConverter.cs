// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IJumpListItemBackgroundConverter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (JumpListItemBackgroundConverter))]
  [Guid(2165799000, 53796, 16652, 177, 108, 197, 182, 187, 97, 136, 178)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IJumpListItemBackgroundConverter
  {
    Brush Enabled { get; set; }

    Brush Disabled { get; set; }
  }
}
