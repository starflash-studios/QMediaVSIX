// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IManipulationStartingRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [Guid(416691895, 21412, 19477, 164, 152, 243, 169, 202, 33, 42, 66)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ManipulationStartingRoutedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IManipulationStartingRoutedEventArgs
  {
    ManipulationModes Mode { get; set; }

    UIElement Container { get; set; }

    ManipulationPivot Pivot { get; set; }

    bool Handled { get; set; }
  }
}
