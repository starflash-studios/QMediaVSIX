// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioGraphBatchUpdater
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>An object that, upon creation with CreateBatchUpdater, causes all subsequent modifications to all nodes in an AudioGraph to be accumulated and then committed once your app closes or disposes of the batch updater object.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class AudioGraphBatchUpdater : IClosable
  {
    [MethodImpl]
    public extern void Close();
  }
}
