// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.TargetFileRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  /// <summary>Provides information about a targetfilerequested event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class TargetFileRequestedEventArgs : ITargetFileRequestedEventArgs
  {
    /// <summary>Gets a targetFileRequest object that is used to respond to a targetfilerequested event.</summary>
    /// <returns>The targetFileRequest object that is used to respond to a targetfilerequested event.</returns>
    public extern TargetFileRequest Request { [MethodImpl] get; }
  }
}
