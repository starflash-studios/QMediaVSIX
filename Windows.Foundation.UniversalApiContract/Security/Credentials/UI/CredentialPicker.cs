// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.UI.CredentialPicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials.UI
{
  /// <summary>Creates an asynchronous object that displays a dialog box of credentials to the user and collects the user's response.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ICredentialPickerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public static class CredentialPicker
  {
    /// <summary>Displays a dialog box to the user and collects credentials from the user.</summary>
    /// <param name="options">The options on displaying and collecting the credential box.</param>
    /// <returns>The credential and options from the user.</returns>
    [Overload("PickWithOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<CredentialPickerResults> PickAsync(
      CredentialPickerOptions options);

    /// <summary>Constructor used to initiate asynchronous prompting operations using two inputs.</summary>
    /// <param name="targetName">The target name to display.</param>
    /// <param name="message">The message to display in the dialog box.</param>
    /// <returns>The credential and options from the user.</returns>
    [RemoteAsync]
    [Overload("PickWithMessageAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<CredentialPickerResults> PickAsync(
      string targetName,
      string message);

    /// <summary>Constructor used to initiate asynchronous prompting operations using three inputs.</summary>
    /// <param name="targetName">The target name to display.</param>
    /// <param name="message">The message to display in the dialog box.</param>
    /// <param name="caption">The caption to display in the dialog box.</param>
    /// <returns>The credential and options from the user.</returns>
    [Overload("PickWithCaptionAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<CredentialPickerResults> PickAsync(
      string targetName,
      string message,
      string caption);
  }
}
