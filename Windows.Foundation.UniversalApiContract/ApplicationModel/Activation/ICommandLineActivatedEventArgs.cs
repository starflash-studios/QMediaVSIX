// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ICommandLineActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Defines the interface for providing info, such as the command-line arguments, when an app is activated from the command line.</summary>
  [Guid(1158039340, 106, 18667, 138, 251, 208, 122, 178, 94, 51, 102)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public interface ICommandLineActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Provides info about the activation of the app such as what arguments were provided and the current directory path.</summary>
    /// <returns>The activation info.</returns>
    CommandLineActivationOperation Operation { get; }
  }
}
