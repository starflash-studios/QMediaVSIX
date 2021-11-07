// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DependencyPropertyChangedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents the method that will handle events that occur when a DependencyProperty is changed on a particular DependencyObject implementation.</summary>
  /// <param name="sender">The source of the event (typically the object where the property changed).</param>
  /// <param name="e">The event data.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(153239130, 30142, 17561, 129, 128, 29, 220, 0, 84, 33, 192)]
  public delegate void DependencyPropertyChangedEventHandler(
    object sender,
    DependencyPropertyChangedEventArgs e);
}
