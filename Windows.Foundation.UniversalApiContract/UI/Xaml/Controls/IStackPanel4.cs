// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IStackPanel4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1139537910, 12694, 16686, 138, 149, 173, 208, 2, 255, 67, 240)]
  [ExclusiveTo(typeof (StackPanel))]
  [WebHostHidden]
  internal interface IStackPanel4
  {
    double Spacing { get; set; }
  }
}
