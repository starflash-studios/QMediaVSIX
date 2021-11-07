// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.UserActivityVisualElements
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Shell;

namespace Windows.ApplicationModel.UserActivities
{
  /// <summary>Contains information, such as the description and icon, that can be shown in the details tile for a UserActivity.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UserActivityVisualElements : 
    IUserActivityVisualElements,
    IUserActivityVisualElements2
  {
    /// <summary>Gets and sets the display text that is used for the details tile text for this **UserActivity**.</summary>
    /// <returns>The display text.</returns>
    public extern string DisplayText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the description text that is used for the details tile for this **UserActivity**.</summary>
    /// <returns>The description.</returns>
    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the background color for the details tile for this **UserActivity**.</summary>
    /// <returns>The color for the background.</returns>
    public extern Color BackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the visual information about a user activity.</summary>
    /// <returns>The visual information such as the URI for the icon, text used by screen readers, and so on.</returns>
    public extern UserActivityAttribution Attribution { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the content that is used for the details tile for this **UserActivity**</summary>
    /// <returns>The content of the tile.</returns>
    public extern IAdaptiveCard Content { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Set the text which is shown in the top banner of the activity card.</summary>
    /// <returns>The text that will appear in the top banner of the activity card.</returns>
    public extern string AttributionDisplayText { [MethodImpl] get; [MethodImpl] set; }
  }
}
