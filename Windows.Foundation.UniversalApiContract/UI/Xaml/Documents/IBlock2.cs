// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IBlock2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Block))]
  [Guid(1590148595, 4915, 19090, 131, 24, 108, 174, 220, 18, 239, 137)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IBlock2
  {
    TextAlignment HorizontalTextAlignment { get; set; }
  }
}
