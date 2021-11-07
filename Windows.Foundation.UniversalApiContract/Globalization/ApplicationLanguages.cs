// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ApplicationLanguages
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Globalization
{
  /// <summary>Specifies the language-related preferences that the app can use and maintain.</summary>
  [Static(typeof (IApplicationLanguagesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IApplicationLanguagesStatics2), 393216, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class ApplicationLanguages
  {
    /// <summary>Retrieves the language preferences of the specified user. This API is part of support for multi-user apps (MUA).</summary>
    /// <param name="user">The user to retrieve preferences for.</param>
    /// <returns>A list of normalized BCP-47 language tags representing the language preferences of the specified user.</returns>
    [MethodImpl]
    public static extern IVectorView<string> GetLanguagesForUser(User user);

    /// <summary>Gets or sets an override for the app's preferred language, expressed as a BCP-47 language tag. This setting is persisted.</summary>
    /// <returns>A BCP-47 language tag. The app can set it to override the top language of the user's ranked list of preferred languages (ApplicationLanguages.Languages ), and its value will persist between app sessions. It must be a single language tag; a delimited list of language tags will fail.</returns>
    public static extern string PrimaryLanguageOverride { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the ranked list of current runtime language values preferred by the user.</summary>
    /// <returns>A computed list of languages that merges the app's declared supported languages (ApplicationLanguages.ManifestLanguages ) with the user's ranked list of preferred languages.</returns>
    public static extern IVectorView<string> Languages { [MethodImpl] get; }

    /// <summary>Gets the app's declared list of supported languages.</summary>
    /// <returns>The list of supported languages declared in the app's manifest.</returns>
    public static extern IVectorView<string> ManifestLanguages { [MethodImpl] get; }
  }
}
