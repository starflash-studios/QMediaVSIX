// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ListViewItemToKeyHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the method that will handle callback for the GetRelativeScrollPosition method.</summary>
  /// <returns>The key of the item.</returns>
  /// <param name="item">The ListView item.</param>
  [Guid(1794497142, 32395, 19089, 154, 86, 70, 12, 180, 125, 82, 63)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public delegate string ListViewItemToKeyHandler(object item);
}
