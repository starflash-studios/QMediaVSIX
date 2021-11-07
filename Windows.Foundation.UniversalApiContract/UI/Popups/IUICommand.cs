// Decompiled with JetBrains decompiler
// Type: Windows.UI.Popups.IUICommand
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Popups
{
  /// <summary>Represents a command in a context menu or message dialog box.</summary>
  [Guid(1341733493, 16709, 18431, 172, 127, 223, 241, 193, 250, 91, 15)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IUICommand
  {
    /// <summary>Gets or sets the label for the command.</summary>
    /// <returns>The label for the command.</returns>
    string Label { get; set; }

    /// <summary>Gets or sets the handler for the event that is fired when the user invokes the command.</summary>
    /// <returns>The event handler for the command.</returns>
    UICommandInvokedHandler Invoked { get; set; }

    /// <summary>Gets or sets the identifier of the command.</summary>
    /// <returns>Represents the identifier of the command.</returns>
    object Id { [return: Variant] get; [param: Variant] set; }
  }
}
