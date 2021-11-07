// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBlock3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3058818394, 16971, 18627, 155, 103, 72, 111, 78, 19, 152, 153)]
  [ExclusiveTo(typeof (TextBlock))]
  internal interface ITextBlock3
  {
    bool IsTextScaleFactorEnabled { get; set; }
  }
}
