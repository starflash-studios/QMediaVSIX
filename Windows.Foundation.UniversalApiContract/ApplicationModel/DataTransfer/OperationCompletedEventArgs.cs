// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.OperationCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>Contains info about the action that a target app completed during a paste operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class OperationCompletedEventArgs : 
    IOperationCompletedEventArgs,
    IOperationCompletedEventArgs2
  {
    /// <summary>Specifies the operation that the target app completed.</summary>
    /// <returns>An enumeration that specifies what operation (such as copy or move) was completed. At most one operation flag can be set.</returns>
    public extern DataPackageOperation Operation { [MethodImpl] get; }

    /// <summary>Gets the accepted format Id.</summary>
    /// <returns>The accepted format Id.</returns>
    public extern string AcceptedFormatId { [MethodImpl] get; }
  }
}
