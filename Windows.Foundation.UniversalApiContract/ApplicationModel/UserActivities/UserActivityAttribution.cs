// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.UserActivityAttribution
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  /// <summary>Provides graphical information about a user activity. Overrides information the system provides about the user activity.</summary>
  [Activatable(typeof (IUserActivityAttributionFactory), 327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(327680, "Windows.Foundation.UniversalApiContract")]
  public sealed class UserActivityAttribution : IUserActivityAttribution
  {
    [MethodImpl]
    public extern UserActivityAttribution(Uri iconUri);

    /// <summary>Create a **UserActivityAttribution** object.</summary>
    [MethodImpl]
    public extern UserActivityAttribution();

    /// <summary>Get or set the Uniform Resource Identifier (URI) for the icon image.</summary>
    /// <returns>The URI that identifies the icon image.</returns>
    public extern Uri IconUri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or set the text that describes the icon.</summary>
    /// <returns>The alternative text string.</returns>
    public extern string AlternateText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or set whether to allow Windows to append a query string to the image URI supplied from IconUri when retriving the image. The query string includes information that can be used to choose the ideal image based on the DPI of the display, the high contrast setting, and the user's language.</summary>
    /// <returns>**True** to allow windows to append a query string to the image URI; **false** otherwise.</returns>
    public extern bool AddImageQuery { [MethodImpl] get; [MethodImpl] set; }
  }
}
