// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICommandBarElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines the compact view for command bar elements.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1737592347, 62165, 17617, 139, 132, 146, 184, 127, 128, 163, 80)]
  public interface ICommandBarElement
  {
    /// <summary>Gets or sets a value that indicates whether the element is shown with no label and reduced padding.</summary>
    /// <returns>**true** if the element is shown in its compact state; otherwise, **false**. The default is **false**.</returns>
    bool IsCompact { get; set; }
  }
}
