// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ItemsChangedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents the method that will handle the ItemsChanged event.</summary>
  /// <param name="sender">The source of the event.</param>
  /// <param name="e">The event data.</param>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(394418110, 41732, 18479, 139, 240, 185, 210, 227, 150, 18, 163)]
  public delegate void ItemsChangedEventHandler(object sender, ItemsChangedEventArgs e);
}
