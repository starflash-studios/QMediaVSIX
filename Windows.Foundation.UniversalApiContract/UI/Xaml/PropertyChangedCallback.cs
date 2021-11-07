// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.PropertyChangedCallback
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents the callback that is invoked when the effective property value of a dependency property changes.</summary>
  /// <param name="d">The DependencyObject on which the property has changed value.</param>
  /// <param name="e">Event data that is issued by any event that tracks changes to the effective value of this property.</param>
  [WebHostHidden]
  [Guid(1520405029, 53570, 17572, 130, 49, 253, 103, 103, 36, 242, 155)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void PropertyChangedCallback(
    DependencyObject d,
    DependencyPropertyChangedEventArgs e);
}
