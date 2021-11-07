// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.CurrentChangingEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Represents a method that can handle the CurrentChanging event of an ICollectionView implementation.</summary>
  /// <param name="sender">The source of the event.</param>
  /// <param name="e">The event data.</param>
  [Guid(4085812664, 5023, 19918, 141, 201, 247, 241, 68, 77, 17, 133)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void CurrentChangingEventHandler(object sender, CurrentChangingEventArgs e);
}
