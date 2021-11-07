// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareUIOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>This class represents the options that are available to the user when showing the ShareUI.</summary>
  [Activatable(327680, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772164)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ShareUIOptions : IShareUIOptions
  {
    /// <summary>Creates a new ShareUIOptions object.</summary>
    [MethodImpl]
    public extern ShareUIOptions();

    /// <summary>Gets or sets the share UI theme.</summary>
    /// <returns>The share UI theme.</returns>
    public extern ShareUITheme Theme { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the selection rectangle.</summary>
    /// <returns>The selection rectangle.</returns>
    public extern IReference<Rect> SelectionRect { [MethodImpl] get; [MethodImpl] set; }
  }
}
