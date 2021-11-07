// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextTextRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  /// <summary>Provides data for the TextRequested event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CoreTextTextRequestedEventArgs : ICoreTextTextRequestedEventArgs
  {
    /// <summary>Gets information about a TextRequested event.</summary>
    /// <returns>An object that represents information about a TextRequested event.</returns>
    public extern CoreTextTextRequest Request { [MethodImpl] get; }
  }
}
