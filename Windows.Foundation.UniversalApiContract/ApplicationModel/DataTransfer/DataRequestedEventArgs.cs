// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DataRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>Contains information about the DataRequested event. The system fires this event when the user invokes the Share UI.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DataRequestedEventArgs : IDataRequestedEventArgs
  {
    /// <summary>Enables you to get the DataRequest object and either give it data or a failure message.</summary>
    /// <returns>The object used to manage content as part of a share operation.</returns>
    public extern DataRequest Request { [MethodImpl] get; }
  }
}
