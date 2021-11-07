// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICommandBarElement2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines members to manage the command bar overflow menu.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2847871542, 17410, 18056, 185, 135, 157, 43, 155, 123, 242, 189)]
  public interface ICommandBarElement2
  {
    /// <summary>Gets a value that indicates whether this item is in the overflow menu.</summary>
    /// <returns>**true** if this item is in the overflow menu; otherwise, **false**.</returns>
    bool IsInOverflow { get; }

    /// <summary>Gets or sets the order in which this item is moved to the CommandBar overflow menu.</summary>
    /// <returns>The order in which this item is moved to the overflow menu relative to other items.</returns>
    int DynamicOverflowOrder { get; set; }
  }
}
