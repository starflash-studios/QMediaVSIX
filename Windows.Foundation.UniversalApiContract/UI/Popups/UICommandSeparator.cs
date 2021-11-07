// Decompiled with JetBrains decompiler
// Type: Windows.UI.Popups.UICommandSeparator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Popups
{
  /// <summary>Represents a command separator in a context menu.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class UICommandSeparator : IUICommand
  {
    /// <summary>Creates a new instance of the UICommandSeparator class.</summary>
    [MethodImpl]
    public extern UICommandSeparator();

    /// <summary>Gets or sets the label for the command separator.</summary>
    /// <returns>The label for the command separator.</returns>
    public extern string Label { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the handler for the event that is fired for the command separator.</summary>
    /// <returns>The event handler for the command separator.</returns>
    public extern UICommandInvokedHandler Invoked { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the identifier of the command separator.</summary>
    /// <returns>The identifier of the command separator.</returns>
    public extern object Id { [MethodImpl] [return: Variant] get; [MethodImpl] [param: Variant] set; }
  }
}
