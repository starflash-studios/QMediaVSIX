// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInsertionPanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides methods to let an item be inserted between other items in a drag-and-drop operation.</summary>
  [Guid(1804460175, 25895, 19769, 188, 191, 88, 176, 29, 169, 35, 215)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  public interface IInsertionPanel
  {
    /// <summary>Returns the index values of the items that the specified point is between.</summary>
    /// <param name="position">The point for which to get insertion indexes.</param>
    /// <param name="first">The index of the item before the specified point.</param>
    /// <param name="second">The index of the item after the specified point.</param>
    void GetInsertionIndexes(Point position, out int first, out int second);
  }
}
