// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IProtocolActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides data when an app is activated because it is the program associated with a protocol.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1620440285, 47040, 18091, 129, 254, 217, 15, 54, 208, 13, 36)]
  public interface IProtocolActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Gets the Uniform Resource Identifier (URI) for which the app was activated.</summary>
    /// <returns>The Uniform Resource Identifier (URI).</returns>
    Uri Uri { get; }
  }
}
