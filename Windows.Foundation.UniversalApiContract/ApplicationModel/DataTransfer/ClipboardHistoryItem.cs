// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ClipboardHistoryItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>Represents an item in the clipboard history.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ClipboardHistoryItem : IClipboardHistoryItem
  {
    /// <summary>Gets the ID of the current item in the clipboard history.</summary>
    /// <returns>The ID of the current item in the clipboard history.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the date and time the current item was added to the clipboard history.</summary>
    /// <returns>The date and time the current item was added to the clipboard history.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }

    /// <summary>Gets the data for the current item in the clipboard history.</summary>
    /// <returns>The data for the current item in the clipboard history.</returns>
    public extern DataPackageView Content { [MethodImpl] get; }
  }
}
