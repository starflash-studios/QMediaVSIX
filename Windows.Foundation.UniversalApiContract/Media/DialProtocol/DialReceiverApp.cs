// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.DialReceiverApp
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  /// <summary>Provides a mechanism for server apps to supply requested data to the DIAL REST service, which can be queried by client apps.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IDialReceiverAppStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class DialReceiverApp : IDialReceiverApp, IDialReceiverApp2
  {
    /// <summary>Retrieves the a map of key/value pairs representing the data previously set with SetAdditionalDataAsync.</summary>
    /// <returns>A map of key/value pairs representing the data previously set with **SetAdditionalDataAsync**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IMap<string, string>> GetAdditionalDataAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetAdditionalDataAsync(
      IIterable<IKeyValuePair<string, string>> additionalData);

    /// <summary>Asynchronously gets the unique device name of the DIAL server device.</summary>
    /// <returns>An asynchronous operation that returns a string on completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetUniqueDeviceNameAsync();

    /// <summary>Gets an instance of the **DialReceiverApp** class.</summary>
    /// <returns>An instance of the **DialReceiverApp** class.</returns>
    public static extern DialReceiverApp Current { [MethodImpl] get; }
  }
}
