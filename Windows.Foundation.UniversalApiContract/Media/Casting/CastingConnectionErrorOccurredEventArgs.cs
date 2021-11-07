// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.CastingConnectionErrorOccurredEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  /// <summary>Represents arguments for the ErrorOccurred event from the CastingConnection</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class CastingConnectionErrorOccurredEventArgs : 
    ICastingConnectionErrorOccurredEventArgs
  {
    /// <summary>Gets the particular error that triggered the casting error event, ErrorOccurred.</summary>
    /// <returns>The error status when starting or ending a casting connection.</returns>
    public extern CastingConnectionErrorStatus ErrorStatus { [MethodImpl] get; }

    /// <summary>Gets human-readable message to accompany the error status code, ErrorStatus.</summary>
    /// <returns>The human-readable message.</returns>
    public extern string Message { [MethodImpl] get; }
  }
}
