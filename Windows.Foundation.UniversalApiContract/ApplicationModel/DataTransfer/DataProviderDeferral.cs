// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DataProviderDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>Used by a source app's deferral delegate to notify a DataPackage object that the source app will produce data from another asynchronous function.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  public sealed class DataProviderDeferral : IDataProviderDeferral
  {
    /// <summary>Informs a DataPackage that it is ready for processing.</summary>
    [MethodImpl]
    public extern void Complete();
  }
}
