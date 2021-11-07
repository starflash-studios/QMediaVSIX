// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRowDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1253763113, 55308, 19038, 164, 140, 248, 179, 211, 182, 83, 61)]
  [ExclusiveTo(typeof (RowDefinition))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IRowDefinition
  {
    GridLength Height { get; set; }

    double MaxHeight { get; set; }

    double MinHeight { get; set; }

    double ActualHeight { get; }
  }
}
