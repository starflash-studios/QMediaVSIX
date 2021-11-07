// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.DialAppStateDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  /// <summary>Represents the state of the DIAL app.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DialAppStateDetails : IDialAppStateDetails
  {
    /// <summary>Gets the state of the application at the time the GetAppStateAsync was completed.</summary>
    /// <returns>The app state.</returns>
    public extern DialAppState State { [MethodImpl] get; }

    /// <summary>Gets the entire XML response that is provided by the app when state of the app was requested.</summary>
    /// <returns>The full XML response.</returns>
    public extern string FullXml { [MethodImpl] get; }
  }
}
