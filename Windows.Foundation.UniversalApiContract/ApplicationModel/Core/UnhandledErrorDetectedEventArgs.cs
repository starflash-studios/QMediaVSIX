// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.UnhandledErrorDetectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  /// <summary>Provides UnhandledError event data for UnhandledErrorDetected events.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class UnhandledErrorDetectedEventArgs : IUnhandledErrorDetectedEventArgs
  {
    /// <summary>Gets the error info object that can be used to handle the event or propagate the error through a language-specific error.</summary>
    /// <returns>An object that represents the unhandled error.</returns>
    public extern UnhandledError UnhandledError { [MethodImpl] get; }
  }
}
