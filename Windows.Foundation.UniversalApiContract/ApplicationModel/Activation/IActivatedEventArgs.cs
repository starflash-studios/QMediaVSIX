// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides common properties for all activation types.</summary>
  [Guid(3479508755, 52488, 20440, 182, 151, 162, 129, 182, 84, 78, 46)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IActivatedEventArgs
  {
    /// <summary>Gets the reason that this app is being activated.</summary>
    /// <returns>One of the enumeration values.</returns>
    ActivationKind Kind { get; }

    /// <summary>Gets the execution state of the app before this activation.</summary>
    /// <returns>One of the enumeration values.</returns>
    ApplicationExecutionState PreviousExecutionState { get; }

    /// <summary>Gets the splash screen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The splash screen object.</returns>
    SplashScreen SplashScreen { get; }
  }
}
