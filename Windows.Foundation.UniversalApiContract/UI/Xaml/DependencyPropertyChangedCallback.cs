// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DependencyPropertyChangedCallback
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents the callback that is invoked when a property value changes, for property change notifications that are registered with the RegisterPropertyChangedCallback technique.</summary>
  /// <param name="sender">The object instance that holds the property to register for property-changed notification.</param>
  /// <param name="dp">The dependency property identifier of the property to register for property-changed notification.</param>
  [Guid(1166556438, 10175, 19393, 172, 38, 148, 193, 96, 31, 58, 73)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void DependencyPropertyChangedCallback(
    DependencyObject sender,
    DependencyProperty dp);
}
