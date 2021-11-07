// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.RoutedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents the method that will handle routed events.</summary>
  /// <param name="sender">The object where the event handler is attached.</param>
  /// <param name="e">The event data.</param>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2824267380, 45238, 19395, 187, 168, 27, 160, 110, 64, 212, 181)]
  public delegate void RoutedEventHandler(object sender, RoutedEventArgs e);
}
