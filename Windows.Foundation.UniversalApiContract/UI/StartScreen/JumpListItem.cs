// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.JumpListItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  /// <summary>Provides functionality for creating and defining jump list items for an app's jump list.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IJumpListItemStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class JumpListItem : IJumpListItem
  {
    /// <summary>Gets the JumpListItemKind of a jump list item.</summary>
    /// <returns>The JumpListItemKind enumeration indicating the kind of item represented by a jump list item.</returns>
    public extern JumpListItemKind Kind { [MethodImpl] get; }

    /// <summary>Gets the command line arguments for the jump list item.</summary>
    /// <returns>The jump list item command line arguments.</returns>
    public extern string Arguments { [MethodImpl] get; }

    /// <summary>Gets a boolean indicating whether the jump list item was removed from the app's jump list by the user.</summary>
    /// <returns>True when a user manually removed a jump list item from the app's jump list, otherwise False.</returns>
    public extern bool RemovedByUser { [MethodImpl] get; }

    /// <summary>Gets or sets the jump list item task description.</summary>
    /// <returns>The jump list item task description specified as a string. If localization is desired, this string must be a *ms-resource:* scheme specified URI.</returns>
    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the jump list item display name. The display name can also be specified as a parameter using the CreateWithArguments method when the jump list item is created.</summary>
    /// <returns>The display name of the jump list item in the app's jump list. If localization is desired, this string must be a*ms-resource:* scheme specified URI.</returns>
    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the jump list item custom group name. If no name is specified, the item will be added to the Tasks group by default.</summary>
    /// <returns>The custom group name for the jump list item specified as a string. If localization is desired, this string must be a *ms-resource:* scheme specified URI.</returns>
    public extern string GroupName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the jump list item's logo.</summary>
    /// <returns>The Uri for the jump list item logo. This can be specified using one of these schemes:&lt;termdeflist&gt;&lt;termdef&gt;&lt;name&gt;ms-appx:///&lt;/name&gt;A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.&lt;/termdef&gt;&lt;termdef&gt;&lt;name&gt;ms-appdata:///local/&lt;/name&gt;A file found in the per-user app storage.&lt;/termdef&gt;&lt;/termdeflist&gt;</returns>
    public extern Uri Logo { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates a new jump list item for an app's jump list.</summary>
    /// <param name="arguments">String that specifies any command line arguments that should be passed onto the app when the jump list item is selected by a user.</param>
    /// <param name="displayName">String that specifies a display name for the jump list item. If localization is desired, this string must be a *ms-resource:* scheme specified URI.</param>
    /// <returns>A jump list item with the specified parameters that can be added to an app's jump list through the items property.</returns>
    [MethodImpl]
    public static extern JumpListItem CreateWithArguments(
      string arguments,
      string displayName);

    /// <summary>Creates a jump list item that is an inert separator for a custom group within the app's jump list.</summary>
    /// <returns>A jump list item that can be added to an app's jump list through the items property.</returns>
    [MethodImpl]
    public static extern JumpListItem CreateSeparator();
  }
}
