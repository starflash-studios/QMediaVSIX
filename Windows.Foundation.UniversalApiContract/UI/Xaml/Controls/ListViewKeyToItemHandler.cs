// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ListViewKeyToItemHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the asynchronous method that will handle callback for the SetRelativeScrollPositionAsync method.</summary>
  /// <returns>An asynchronous operation that, upon successful completion, returns the ListView item represented by the specified key.</returns>
  /// <param name="key">The key of the ListView item.</param>
  [WebHostHidden]
  [Guid(654137429, 46384, 18056, 185, 240, 66, 130, 73, 23, 142, 248)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate IAsyncOperation<object> ListViewKeyToItemHandler(string key);
}
