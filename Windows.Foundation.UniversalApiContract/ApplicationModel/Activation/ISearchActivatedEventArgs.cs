// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ISearchActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information about the activated event that fires when an app is used to search.</summary>
  [Guid(2360568145, 22728, 17379, 148, 188, 65, 211, 63, 139, 99, 14)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ISearchActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>The text that the user wants the app to search for. The user entered this text into the search box of the search pane.</summary>
    /// <returns>The text to find.</returns>
    string QueryText { get; }

    /// <summary>The Internet Engineering Task Force (IETF) language tag (BCP 47 standard) that identifies the language currently associated with the user's text input device.</summary>
    /// <returns>The Internet Engineering Task Force (IETF) BCP 47 standard language tag.</returns>
    string Language { get; }
  }
}
